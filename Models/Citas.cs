
using Microsoft.EntityFrameworkCore;
using EDUSEX.conexion;

namespace EDUSEX.Models
{

    public class Citas
    {
        public int IdCitas { get; set; }
        public int IdUsuario { get; set; }
        public int IdHospital { get; set; }

        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }

        public Citas() 
        {
           this.IdCitas = 0;
            this.IdUsuario = 0;
            this.IdHospital = 0;
            this.FechaCita = string.Empty;
            this.HoraCita = string.Empty;
            this.Motivo = string.Empty;
            this.Estado = string.Empty;
        }
    }
}