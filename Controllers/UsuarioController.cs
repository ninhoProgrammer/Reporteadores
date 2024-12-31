using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reporteadores.Models;

namespace Reporteadores.Controllers
{
    public class UsuarioController : IdentityDbContext<Usuario>
    {
        public UsuarioController(DbContextOptions<ComparteContext> options) : base(options) { }

        // Agrega las tablas adicionales si es necesario
        public DbSet<Usuario> Usuarios { get; set; }
        // GET: UsuarioController
        
    }
}
