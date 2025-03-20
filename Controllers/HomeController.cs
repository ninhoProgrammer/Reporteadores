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
       
        public IActionResult Reporte()
        {
            var username = HttpContext.Session.GetString("Username"); // Recupera el nombre de usuario de la sesi�n

            if (username != null)
            {
                var usuario = _BContext.Reportes.Select(u => new { u.ReNombre });

                // Llenar el primer ComboBox con los a�os �nicos
                var periodos = _BContext.Periodos.Select(p => p.PeYear).Distinct().ToList().OrderByDescending(p => p);
                ViewBag.PeAnio = periodos;
                var reportes = _BContext.Reportes.ToList();
                ViewBag.Reporte = reportes;
                ViewData["UserActive"] = username;
                if (usuario != null)
                    return View();
                else
                    return RedirectToAction("ErrorPage", "Home");
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
        public IActionResult SoportReportSend(string name, string email, string problem)
        {
            string mensaje = EnviarCorreo(name, email, problem);

            ViewBag.Nombre = name;
            ViewBag.Email = email;
            ViewBag.Problema = problem;
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

                string exePath = @"C:\Users\mario\Documents\GitHub\repotsEjecute\bin\Debug\repotsEjecute.exe";
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

        private string EnviarCorreo(string nombre, string email, string problema)
        {
            try
            {
                var mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("mario.hernandez@grupoabg.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Soporte Técnico: Extenciones NOMIABG";
                mailMessage.Body = $"Nombre: {nombre}\nCorreo Electrónico: {email}\nDescripción del Problema: {problema}";

                using (var smtpClient = new SmtpClient("smtp.hostinger.com"))
                {
                    smtpClient.Port = 465;
                    smtpClient.Credentials = new System.Net.NetworkCredential("mario.hernandez@grupoabg.com", "Mail_MH_0243");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                }

                return "Correo enviado exitosamente.";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error -> {ex.Message}");
                return $"Error al enviar el correo: {ex.Message}";
            }
        }
    }
}
