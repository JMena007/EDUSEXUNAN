
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EDUSEX.Models 
{
  
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string  Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Cedula { get; set; }

        public int Edad { get; set; }

        public string Sexo { get; set; }
         
        public string Telefono { get; set; }

        public string Correo { get; set; }


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
    }

}

  
