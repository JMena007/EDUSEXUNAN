using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUSEX.Models
{
    public class Roles
    {

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public Roles(int IdRol, String NombreRol) {
        
          this.IdRol = IdRol;
          this.NombreRol = NombreRol;
        }

        public Roles() { }
    }
}
