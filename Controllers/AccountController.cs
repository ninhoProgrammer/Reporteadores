using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Reporteadores.Models;

namespace Reporteadores.Controllers
{
    public class AccountController : Controller
    {
        private ComparteContext db = new ComparteContext();

        //private ILoginServices _loginService;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AccountController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(Usuario model)
        {
            string log = "";
            ViewBag.ErrorMessage = null; // Inicializa el mensaje de error
            try
            {
                var username = HttpContext.Session.GetString("Username"); // Recupera el nombre de usuario de la sesión
                
                if (username == null && model.UsCorto != null && model.UsPasswrd != null)
                {
                    var usuario = db.Usuarios
                        .Where(u => u.UsCorto == model.UsCorto)
                        .Select(u => new { u.UsCorto, u.UsPasswrd }) // Solo selecciona 'UsCorto' y 'UsPasswrd'
                        .FirstOrDefault();

                    if (usuario != null && usuario.UsPasswrd == model.UsPasswrd)
                    {
                        HttpContext.Session.SetString("Username", model.UsCorto); // Almacena el nombre de usuario en la sesión

                        _userManager.UpdateAsync(model);
                        _signInManager.RefreshSignInAsync(model);

                        // Autenticación exitosa, redirigir al usuario a la página principal
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        // Si las credenciales no son correctas, establece el mensaje de error
                        log = "Nombre de usuario o contraseña incorrectos.";
                    }
                }
            }
            catch
            {
                log = "Ocurrió un error inesperado. Inténtelo de nuevo.";
            }
            ViewBag.ErrorMessage = log;
            // Si hay un fallo, devuelve la vista con el mensaje de error
            return View(model);
        }
    }
}
