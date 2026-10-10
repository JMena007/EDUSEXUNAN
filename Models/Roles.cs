using EDUSEX.conexion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EDUSEX.Models
{
    public class Roles
    {
        [Key]
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public Roles(int IdRol, String NombreRol)
        {
            this.IdRol = IdRol;
            this.NombreRol = NombreRol;
        }

        public Roles() { }

       

        public static string ObtenerNombreRol(int idRol)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Roles
                    .Where(r => r.IdRol == idRol)
                    .Select(r => r.NombreRol)
                    .FirstOrDefault();
            }
        }
    }
}