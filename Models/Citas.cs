
using EDUSEX.conexion;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EDUSEX.Models
{

    public class Citas
    {
        [Key]
        public int IdCita { get; set; }
        public int IdUsuario { get; set; }
        public int IdHospital { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Citas() 
        {
           this.IdCita = 0;
            this.IdUsuario = 1;
            this.IdHospital = 1;
            this.FechaCita = DateTime.Now;
            this.HoraCita = DateTime.Now.TimeOfDay;
            this.Motivo = string.Empty;
            this.Estado = string.Empty;
            this.FechaRegistro = DateTime.Now;
        }
    }
}