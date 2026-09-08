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
                optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=EDUSEX_Proyect_Db;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;");
            }
        }
    }
}
