using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Reporteadores.Models;
using System.Threading;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Mail;

namespace Reporteadores.Controllers
{
    public class HomeController : Controller
    {
        private readonly BarronContext _BContext = new BarronContext();
        private readonly ComparteContext _CContext = new ComparteContext();

        private readonly ILogger<HomeController> _logger;

        //public HomeController(ComparteContext Ccontext, BarronContext BContext, ILogger<HomeController> logger) { 
        //[Route("[controller]/[action]")]
        public HomeController(ILogger<HomeController> logger) 
        { 
            _logger = logger;
        }

        public IActionResult Index()
        {
            var usernameSesion = HttpContext.Session.GetString("Username"); // Recupera el nombre de usuario de la sesi�n
            
            if (usernameSesion != null)
            {
                // El usuario est� autenticado, realiza la l�gica deseada
                ViewData["UserActive"] = usernameSesion;
                return View();
            }
            else
            {
                // El usuario no est� autenticado, redirigir a la p�gina de inicio de sesi�n
                return RedirectToAction("Index", "Account");
            }
        }

        public IActionResult Nomina()
        {
            var usernameSesion = HttpContext.Session.GetString("Username");

            if (usernameSesion != null)
            {
                List<int> periodos = _BContext.Periodos.Select(p => (int)p.PeYear).Distinct().OrderByDescending(p => p).ToList();
                ViewBag.PeAnio = periodos;
                ViewData["UserActive"] = usernameSesion;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }

        public IActionResult Reporte()
        {
            var username = HttpContext.Session.GetString("Username"); // Recupera el nombre de usuario de la sesi�n

            if (username != null)
            {
                // Llenar el primer ComboBox con los a�os �nicos
                var periodos = _BContext.Periodos.Select(p => p.PeYear).Distinct().ToList().OrderByDescending(p => p);
                ViewBag.PeAnio = periodos;
                var reportes = _BContext.Reportes.ToList();
                ViewBag.Reporte = reportes;
                ViewData["UserActive"] = username;
                if (username != null)
                    return View();
                else
                    return RedirectToAction("ErrorPage", "Home");
            }
            return RedirectToAction("Index", "Account");
        }

        [HttpGet]
        public JsonResult NominaView(int peAnio, int peTipo, int peNumero)
        {
            var query = _BContext.Nominas
                .Where(p => p.PeYear == peAnio && p.PeTipo == peTipo && p.PeNumero == peNumero)
                .Select(p => new
                {
                    p.PeYear,
                    p.CbSalario,
                    PeriodoFin = p.NoDiasIn,
                    Estado = p.NoDiasFi,
                    Descripcion = p.NoObserva,
                    Percepcion = p.NoPercepc,
                    Deduccion = p.NoDeducci,
                    Neto = p.NoNeto,
                    Empleados = p.CbCodigo,
                    Fecha = DateTime.Now.ToString("dd/MM/yyyy")
                })
                .FirstOrDefault();

            return Json(query);
            
        }

        public IActionResult Privacy()
        {
            string pdfUrl = "http://189.203.75.86/Kioscos/SitioRecibos/Aviso.pdf";
            return Redirect(pdfUrl); // Redirige al navegador para que abra el PDF
        }

        [HttpGet]
        public IActionResult ViewReports(string publicPath)
        {
            var username = HttpContext.Session.GetString("Username");
            ViewData["UserActive"] = username;
             if (username != null)
            {
                ViewData["PublicPath"] = publicPath;
                return View();
            }
            return RedirectToAction("Index", "Account");
        }
       
        

        public IActionResult Signout()
        {
            // no se que paso aqui pero funciona 
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Account");            
        }

        public IActionResult SoporteReporte()
        {
            ViewData["UserActive"] = HttpContext.Session.GetString("Username");
            return View();
        }

        [HttpPost]
        public IActionResult SoportReportSend(string name, string email,string phone, string problem)
        {
            string mensaje = EnviarCorreo(name, email, phone, problem);

            ViewBag.Mensaje = mensaje;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string? GetSqlQueryFromRdl(string rdlPath)
        {
            // Leer todo el contenido del archivo
            string content = string.Empty;
            string sqlQuery = string.Empty;
            if (!System.IO.File.Exists(rdlPath))
            {
               content = System.IO.File.ReadAllText(rdlPath);
            }
            // Usar una expresi�n regular para encontrar el texto entre las etiquetas <CommandText> y </CommandText>
            string pattern = @"<CommandText>(.*?)<\/CommandText>";
            Match match = Regex.Match(content, pattern, RegexOptions.Singleline);

            if (match.Success)
            {
                sqlQuery = match.Groups[1].Value.Trim();
                Console.WriteLine("Consulta SQL extra�da:");
                Console.WriteLine(sqlQuery);
            }
            else
            {
                Console.WriteLine("No se encontro ninguna consulta SQL entre las etiquetas <CommandText>.");
            }
            return sqlQuery;
        }

        // M�todo para obtener los tipos (PeTipo) seg�n el a�o seleccionado (PeAnio)
        [HttpGet]
        public JsonResult GetPeTipos(int peAnio)
        {
            var tipos = _BContext.Periodos
                .Where(p => p.PeYear == peAnio)
                .Select(p => p.PeTipo)
                .Distinct()
                .ToList();

            try
            { 
                return Json(tipos); 
            } 
            catch (Exception ex) 
            { 
                return Json(new { error = ex.Message }); 
            }
              
        }

        // M�todo para obtener los n�meros de periodo (PeNumero) seg�n el tipo seleccionado (PeTipo)
        [HttpGet]
        public JsonResult GetTeNumeroPeriodos(int peAnio,int peTipo)
        {
            var numeros = _BContext.Periodos
                .Where(p => p.PeTipo == peTipo && p.PeYear == peAnio) // Filtra por Tipo y A�o
                .Select(p => p.PeNumero) // Selecciona el n�mero
                .Distinct() // Elimina duplicados
                .OrderBy(p => p) // Ordena de menor a mayor
                .ToList(); // Convierte a lista
            return Json(numeros);
        }

        // M�todo para obtener los reportes seg�n el tipo seleccionado (PeTipo)
        [HttpGet]
        private async Task<IActionResult> GenerateReportAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo, bool download, string format)
        {
            var username = HttpContext.Session.GetString("Username");
            ViewData["UserActive"] = username;

            var rutaReporte = await _BContext.Reportes
            .Where(u => u.ReNombre == ReNombre && u.ReCodigo == short.Parse(ReCodigo))
            .Select(u => u.ReArchivo)
            .FirstOrDefaultAsync();

            if (rutaReporte == null)
            {
                ViewBag.ErrorMessage = "El reporte especificado no existe.";
                return RedirectToAction("ErrorPage", "Home");
            }

            if (!System.IO.File.Exists(rutaReporte))
            {
                ViewBag.ErrorMessage = "El archivo del reporte no se encontró.";
                return RedirectToAction("ErrorPage", "Home");
            }

            try
            {
                var rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Temp", "ScreenshotsReporte." + format);
                Console.WriteLine($"Root Path: {rootPath}");

                string exePath = @"C:\Users\mario\Documents\GitHub\reportsEjecute\bin\Debug\repotsEjecute.exe";
                string[] parameters = 
                {
                    rutaReporte, 
                    ReCodigo, 
                    ReNombre, 
                    peTipo, 
                    peAnio, 
                    peNumero, 
                    "0", 
                    "true",
                    rootPath,
                    format,
                    "BARRON",
                };

                var psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = string.Join(" ", parameters),
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                using (var process = Process.Start(psi))
                {
                    if (process != null)
                    {
                        string output = await process.StandardOutput.ReadToEndAsync();
                        string error = await process.StandardError.ReadToEndAsync();
                        await process.WaitForExitAsync();
                        if (process.ExitCode == 0)
                        {
                            string filePath = output.Trim();

                            if (System.IO.File.Exists(filePath))
                            {
                                var fileName = Path.GetFileName(filePath);
                                var publicPath = $"/Temp/{fileName}";
                                var publicDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Temp");
                                var destinationPath = Path.Combine(publicDirectory, fileName);
                                if (!Directory.Exists(publicDirectory))
                                    Directory.CreateDirectory(publicDirectory);
                                if (System.IO.File.Exists(filePath))
                                {
                                    if (download)
                                    {
                                        /*using (var sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                        using (var destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
                                        {
                                            await sourceStream.CopyToAsync(destinationStream);
                                        }*/
                                        if (format == "PDF")
                                        {
                                            var fileBytes = await System.IO.File.ReadAllBytesAsync(filePath);
                                            return File(fileBytes, "application/pdf");
                                        }
                                        else
                                        {
                                            var fileBytes = await System.IO.File.ReadAllBytesAsync(filePath);
                                            return File(fileBytes, "application/vnd.ms-excel");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Ruta pública in json: {publicPath}");
                                        return Json(publicPath);
                                    }
                                }
                                else
                                {
                                    return NotFound(new { Success = false, Message = "El archivo generado no se encontró." });
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error: {error}");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Failed to start the process.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
            }

            ViewBag.ErrorMessage = $"Error al generar el reporte";
            return RedirectToAction("ErrorPage", "Home");
        }

        
        public Task<IActionResult> CreateReportsAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo)
        {   
            return GenerateReportAsync(ReCodigo, ReNombre, peTipo, peAnio, peNumero, Activo, false, "pdf");
        }
        [HttpGet]
        public Task<IActionResult> DownloadReportsAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo)
        {
            return GenerateReportAsync(ReCodigo, ReNombre, peTipo, peAnio, peNumero, Activo, true,  "pdf");
        }[HttpGet]
        public Task<IActionResult> ExcelReportsAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo)
        {
            return GenerateReportAsync(ReCodigo, ReNombre, peTipo, peAnio, peNumero, Activo, true, "xml");
        }

        private string EnviarCorreo(string name, string email, string phone,  string problem)
        {
            try
            {
                if (sendMessageITSoport(name, email, phone, problem))
                {
                    if (sendMessage(name, email))
                        return "Correo enviado exitosamente.";
                    else
                        return $"Error al enviar el correo";
                }
                return $"Error al enviar el correo a soporte";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error -> {ex.Message}");
                return $"Error al enviar el correo: {ex.Message}";
            }
        }

        public bool sendMessage(string name, string email)
        {
            bool flag = false;
            using (var mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress("mario.hernandez@grupoabg.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Soporte Técnico: Extensiones NOMIABG";
                mailMessage.IsBodyHtml = true;

                // Cuerpo del correo en formato HTML
                mailMessage.Body = @"
                    <html>
                        <body style=""font-family: Arial, sans-serif; margin: 0; padding: 0; "">
                            <div style=""max-width: 600px; margin: auto; background-color: #ffffff; border-radius: 8px; overflow: hidden; box-shadow: 0 4px 8px rgba(0,0,0,0.1);"">
                                <!-- Encabezado -->
                                <header style=""background-color: #437cb1; color: white; padding: 20px; text-align: center;"">
                                    <h1 style=""margin: 0;"">Soporte Técnico: Extensiones NOMIABG</h1>
                                </header>

                                <!-- Mensaje principal -->
                                <div style=""padding: 20px;"">
                                    <h2 style=""color: #333;"">Hola " + name + @":</h2>
                                    <p style=""line-height: 1.6; color: #555;"">
                                        Su problema ha sido enviado a nuestro equipo de soporte IT. Este es un mensaje automático, por favor no responder a este correo.
                                    </p>
                                    <hr style=""border: 0; height: 1px; background-color: #ddd; margin: 20px 0;"">
                                    <b>Atentamente,</b>
                                    <p style=""color: #555;"">Soporte IT de Grupo ABG</p>
                                    <hr style=""border: 0; height: 1px; background-color: #ddd; margin: 20px 0;"">
                                </div>

                                <!-- Información de contacto -->
                                <div style=""padding: 20px; background-color: #ffffff;"">
                                    <p style=""margin: 0; font-size: 14px; color: #333;"">
                                        <b>GRUPO ABG</b><br>
                                        Calle Naranjos 605 Colonia Jardín<br>
                                        San Luis Potosí, S.L.P. México, 78270
                                    </p>

                                    <!-- Redes sociales -->
                                    <div style=""margin-top: 20px; text-align: center;"">
                                        <a href=""https://www.grupoabg.com"" target=""_blank"" style=""text-decoration: none;"">
                                            <img src=""https://img.icons8.com/?size=100&id=yOfOLQrIJWja&format=png&color=000000"" alt=""Website"" style=""width: 40px; margin: 0 10px;"">
                                        </a>
                                        <a href=""tel:+524441518500"" style=""text-decoration: none;"">
                                            <img src=""https://img.icons8.com/?size=100&id=6rYRCUAFOL4w&format=png&color=000000"" alt=""Teléfono"" style=""width: 40px; margin: 0 10px;"">
                                        </a>
                                        <a href=""mailto:soporte@grupoabg.com"" style=""text-decoration: none;"">
                                            <img src=""https://img.icons8.com/?size=100&id=HyjRWfleuVje&format=png&color=000000"" alt=""Correo"" style=""width: 40px; margin: 0 10px;"">
                                        </a>
                                    </div>
                                </div>

                                <!-- Footer -->
                                <footer style=""padding: 20px; background-color: #437cb1; color: white; text-align: center; font-size: 12px;"">
                                    <p>
                                        La atención vía telefónica está disponible de <b>Lunes a Viernes</b> en un horario de <b>9:00 a.m a 2:00 p.m</b> 
                                        y de <b>4:00 p.m a 6:00 p.m</b> marcando al número telefónico <b>444-151-85-00 Ext.138</b>, donde atenderemos tus dudas 
                                        sobre el portal así como brindarte soporte técnico.
                                    </p>
                                    <p style=""margin-top: 10px;"">Grupo ABG - Todos los derechos reservados © 2025</p>
                                </footer>
                            </div>
                        </body>
                    </html>";

                using (var smtpClient = new SmtpClient("smtp.hostinger.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential("mario.hernandez@grupoabg.com", "Mail_MH_0243");
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Send(mailMessage);
                    flag = true;
                }
            }
            return flag;
        }
        public bool sendMessageITSoport(string name, string email, string phone, string problem)
        {
            bool flag = false;
            using (var mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress("mario.hernandez@grupoabg.com");
                mailMessage.To.Add("mario.hernandez@grupoabg.com");
                mailMessage.To.Add("mariohm100293@gmail.com");
                mailMessage.Subject = "Soporte Técnico: Extenciones NOMIABG";
                mailMessage.IsBodyHtml = true;

                // Cuerpo del correo en formato HTML
                mailMessage.Body = $@"
                    <html>
                        <body style='font-family: Arial, sans-serif;'>
                            <h2>Soporte Técnico: Extensiones NOMIABG</h2>
                            <p><strong>Nombre:</strong> {name}</p>
                            <p><strong>Correo Electrónico:</strong> {email}</p>
                            <p><strong>Telefono: </strong> {phone}</p>
                            <p><strong>Descripción del Problema:</strong> {problem}</p>
                            <hr />
                            
                        </body>
                    </html>";

                using (var smtpClient = new SmtpClient("smtp.hostinger.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential("mario.hernandez@grupoabg.com", "Mail_MH_0243");
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Send(mailMessage);
                    flag = true;
                }
            }
            return flag;
        }
    }
}
