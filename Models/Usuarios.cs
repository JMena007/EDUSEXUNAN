using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUSEX.Models 
{
  
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string  Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Cedula { get; set; }

        public int Edad { get; set; }

        public char Sexo { get; set; }
         
        public string Telefono { get; set; }

        public int Correo { get; set; }


        public Usuario(string IdUsuario, string Nombres, string Apellidos, string Cedula, int Edad, Char Sexo, string Telefono) 
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
        
 
    }

}

  
