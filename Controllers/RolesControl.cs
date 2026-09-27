using System;
using System.Collections.Generic;
using System.Text;
using EDUSEX.conexion;
using EDUSEX.Models;
using System.Linq;
using EDUSEX.Views;

namespace EDUSEX.Controllers
{
    internal class RolesControl
    {
        public string ObtenerNombreRol(int idRol)
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
