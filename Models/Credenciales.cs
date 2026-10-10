using EDUSEX.conexion;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EDUSEX.Models
{
    public class Credenciales
    {
        [Key]
        public int IdCredencial { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }

        public Credenciales(int IdCredencial, int IdUsuario, string NombreUsuario, string PasswordHash, int IdRol, bool Activo)
        {
            this.IdCredencial = IdCredencial;
            this.IdUsuario = IdUsuario;
            this.NombreUsuario = NombreUsuario;
            this.PasswordHash = PasswordHash;
            this.IdRol = IdRol;
            this.Activo = Activo;
        }

        public Credenciales() { }

        // --- Lógica de persistencia, movida desde CredencialControl ---

        public void InsertarCredencial()
        {
            using (var context = new EDUSEXContext())
            {
                context.Credenciales.Add(this);
                context.SaveChanges();
            }
        }

        public static Credenciales ValidarLogin(string usuario, string password)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Credenciales
                    .FirstOrDefault(c =>
                        c.NombreUsuario == usuario &&
                        c.PasswordHash == password &&
                        c.Activo);
            }
        }
    }
}