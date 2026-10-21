using EDUSEX.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EDUSEX.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; }

        public Usuarios(int IdUsuario, string Nombres, string Apellidos, string Cedula, int Edad, string Sexo, string Telefono, string Correo)
        {
            this.IdUsuario = IdUsuario;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Telefono = Telefono;
            this.Correo = Correo;
        }

        public Usuarios()
        {

        }

   

        public void InsertarUsuario()
        {
            using (var context = new EDUSEXContext())
            {
                context.Usuarios.Add(this);
                context.SaveChanges();
            }
        }

        public void EditarUsuario()
        {
            using (var context = new EDUSEXContext())
            {
                context.Usuarios.Update(this);
                context.SaveChanges();
            }
        }

        public void EliminarUsuario()
        {
            using (var context = new EDUSEXContext())
            {
                var usuario = context.Usuarios.Find(this.IdUsuario);
                if (usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            }
        }

        public static bool CedulaExiste(string cedula)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Usuarios.Any(u => u.Cedula == cedula);
            }
        }

        public static List<Usuarios> ObtenerUsuarios()
        {
            using (var context = new EDUSEXContext())
            {
                return context.Usuarios.ToList();
            }
        }

        public static Usuarios BuscarPorCedula(string cedula)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Cedula == cedula);
            }
        }

        public static Usuarios BuscarPorCedulaONombre(string valor)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Usuarios.FirstOrDefault(u =>
                    u.Cedula == valor ||
                    u.Nombres.Contains(valor) ||
                    u.Apellidos.Contains(valor));
            }
        }

        public static Usuarios ObtenerUsuarioPorId(int idUsuario)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Usuarios.Find(idUsuario);
            }
        }
    }
}