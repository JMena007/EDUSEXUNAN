using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUSEX.Models
{
    public class Hospitales
    {
        [Key]
        public int IdHospital { get; set; }

        public string NombreHospital { get; set; }

        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string especialidad { get; set; }
        public string Estado { get; set; }
        public Hospitales() { }
    }
}
