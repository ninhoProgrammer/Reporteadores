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
                ViewData["UsuarioActivo"] = usernameSesion;
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

        public IActionResult ViewReports(string publicPath)
        {
            var username = HttpContext.Session.GetString("Username");
            ViewData["UsuarioActivo"] = username;
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
                var periodos = _BContext.Periodos.Select(p => p.PeYear).Distinct().ToList().OrderBy(p => p);
                ViewBag.PeAnio = periodos;
                var reportes = _BContext.Reportes.ToList();
                ViewBag.Reporte = reportes;
                ViewData["UsuarioActivo"] = username;
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
        public IActionResult ErrorPage()
        {
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
        private async Task<IActionResult> GenerateReportAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo, bool download)
        {
            var username = HttpContext.Session.GetString("Username");
            ViewData["UsuarioActivo"] = username;

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
                var parametros = new Dictionary<string, string>
                {
                    { "EMPRESA", "BARRON" },
                    { "REPORTE", "\'" + ReNombre + "\'"},
                    { "ACTIVO", Activo ? "S" : "N" },
                    { "AÑO", peAnio },
                    { "PERIODO", peNumero },
                    { "TIPO", peTipo }
                };

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
                    "true"
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

                            if (!Directory.Exists(publicDirectory))
                                Directory.CreateDirectory(publicDirectory);

                            if (System.IO.File.Exists(filePath))
                            {                                
                                if (download)
                                {
                                    var destinationPath = Path.Combine(publicDirectory, fileName);
                                    System.IO.File.Copy(filePath, destinationPath, true);
                                    var fileBytes = await System.IO.File.ReadAllBytesAsync(destinationPath);
                                    return File(fileBytes, "application/pdf");
                                }
                                else
                                {
                                    Console.WriteLine($"Ruta p�blica in json: {publicPath}");
                                    return Json(new { publicPath });
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
            return GenerateReportAsync(ReCodigo, ReNombre, peTipo, peAnio, peNumero, Activo, false);
        }

        [HttpGet]
        public Task<IActionResult> DownloadReportsAsync(string ReCodigo, string ReNombre, string peTipo, string peAnio, string peNumero, bool Activo)
        {
            return GenerateReportAsync(ReCodigo, ReNombre, peTipo, peAnio, peNumero, Activo, true);
        }
        
    }
}
