using System;
using System.Collections.Generic;
using System.Text;
using EDUSEX.conexion;
using EDUSEX.Models;
using System.Linq;

namespace EDUSEX
{
 
        public static class SesionActual
        {
            public static int IdUsuarioLogueado { get; set; }
            public static string NombreUsuario { get; set; }
            public static string RolUsuario { get; set; }

            public static void Limpiar()
            {
                IdUsuarioLogueado = 0;
                NombreUsuario = null;
                RolUsuario = null;
            }
        }
   
}

