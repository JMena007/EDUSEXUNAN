using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUSEX.conexion
{
    public class EDUSEXContext : DbContext
    {
        // controlador
        public EDUSEXContext()
        {
        }
        public EDUSEXContext(DbContextOptions<EDUSEXContext> options) : base(options)
        {

        }

        // Add DbSet<T> properties here when you create your entities
        public DbSet<Models.Usuarios> Usuarios { get; set; }

        public DbSet<Models.Citas> Citas { get; set; }

        public DbSet<Models.Credenciales> Credenciales { get; set; }

        public DbSet<Models.GuiaEducativa> GuiaEducativa { get; set; }

        public DbSet<Models.Hospitales> Hospitales { get; set; }

        public DbSet<Models.Roles> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=EDUSEX_Proyect_Db;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;");
            }
        }
    }
}
