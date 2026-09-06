using Microsoft.EntityFrameworkCore;
using System;

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

        // Add DbSet<T> properties here when you create your entities
        public DbSet<Models.Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Try to read connection string from environment variable first
                var connectionString = Environment.GetEnvironmentVariable("EDUSEX_CONNECTION");

                // Fallback to LocalDB if environment variable not set
                if (string.IsNullOrEmpty(connectionString))
                {
                    connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
                }

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
