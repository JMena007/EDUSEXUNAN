using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EDUSEX.conexion
{
    public class EDUSEXContext : DbContext
    {
        public EDUSEXContext()
        {
        }

        public EDUSEXContext(DbContextOptions<EDUSEXContext> options) : base(options)
        {
        }

        public DbSet<Models.Roles> Roles { get; set; }
        public DbSet<Models.Usuarios> Usuarios { get; set; }
        public DbSet<Models.Citas> Citas { get; set; }
        public DbSet<Models.Hospitales> Hospitales { get; set; }


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