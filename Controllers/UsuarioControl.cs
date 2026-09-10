using EDUSEX.conexion;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EDUSEX.Models;

namespace EDUSEX.Controllers
{
    internal class UsuarioControl
    {
        public void InsertarUsuario(Models.Usuarios usuario)
        {
            using (EDUSEXContext context = new EDUSEXContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        /* public List<Models.Usuarios> ObtenerUsuarios()
         {
               using (EDUSEXContext context = new EDUSEXContext())
               {
                   return context.Usuarios.ToList();
               } 

         }
         */
        public void Editarusuario(Models.Usuarios usuario)
        {
            using (EDUSEXContext context = new EDUSEXContext())
            {
                context.Usuarios.Update(usuario);
                context.SaveChanges();
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            using (EDUSEXContext context = new EDUSEXContext())
            {
                var usuario = context.Usuarios.Find(idUsuario);
                if (usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            }
        }

        public void BuscarPorCedula(string cedula)
        {
            
        }

    }
}
