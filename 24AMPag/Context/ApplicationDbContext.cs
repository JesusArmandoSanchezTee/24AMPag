using _24AMPag.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;

namespace _24AMPag.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
            { }
            public DbSet<Usuario> Usuarios { get; set; }

            public DbSet<Rol> Roles { get; set; }
            
    }
}
