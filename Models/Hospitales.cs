using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using EDUSEX.conexion;

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
        public bool Estado { get; set; }

        public Hospitales(int IdHospital, string NombreHospital, string Distrito, string Direccion, string Telefono, string especialidad, bool Estado)
        {
            this.IdHospital = IdHospital;
            this.NombreHospital = NombreHospital;
            this.Distrito = Distrito;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.especialidad = especialidad;
            this.Estado = Estado;
        }

        public Hospitales()
        {

        }

        public static List<Hospitales> ObtenerHospitales()
        {
            using (var context = new EDUSEXContext())
            {
                return context.Hospitales.ToList();
            }
        }

        //aqui mostraremos citas de cada hospital
        public void MostrarCitasHospitales ( Citas citas)
        {
            using (var context = new EDUSEXContext())
            {
                
            }
        }
    }
}
