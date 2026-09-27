using EDUSEX.conexion;
using EDUSEX.Models;
using System;
using System.Collections.Generic;
using System.Linq; // <-- FALTABA: sin esto, FirstOrDefault no compila
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

    
        public void InsertarCredencial(Credenciales credencial)
        {
            using (var context = new EDUSEXContext())
            {
                context.Credenciales.Add(credencial);
                context.SaveChanges();
            }
        }
    }
}