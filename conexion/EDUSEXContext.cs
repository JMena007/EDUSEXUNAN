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

        public DbSet<Models.Credenciales> Credenciales { get; set; }
        public DbSet<Models.Roles> Roles { get; set; }
        public DbSet<Models.Usuarios> Usuarios { get; set; }
        public DbSet<Models.Citas> Citas { get; set; }
        public DbSet<Models.Hospitales> Hospitales { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(
                        "appsettings.json",
                        optional: false,
                        reloadOnChange: true
                    )
                    .Build();

                string connectionString =
                    config.GetConnectionString("SupabaseConnection");

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException(
                        "No se encontró la conexión SupabaseConnection en appsettings.json.");
                }
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}