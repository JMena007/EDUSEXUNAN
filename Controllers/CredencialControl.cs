using EDUSEX.conexion;
using EDUSEX.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUSEX.Controllers
{
    public class CredencialControl
    {
        public Credenciales ValidarLogin(string usuario, string password)
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
