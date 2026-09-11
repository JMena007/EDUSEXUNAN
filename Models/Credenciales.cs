using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

       public Credenciales(int IdCredencial, int IdUsuario, string NombreUsuario,string PasswordHash, int IdRol, bool Activo) 
       { 
           this.IdCredencial = IdCredencial;
            this.IdUsuario = IdUsuario;
            this.NombreUsuario = NombreUsuario;
            this.PasswordHash = PasswordHash;
            this.IdRol = IdRol;
            this.Activo = Activo;
       }


    }
}
