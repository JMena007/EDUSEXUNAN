using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUSEX.Models
{
    public class CitaReporte
    {
        public int IdCita { get; set; }
        public string Paciente { get; set; } = "";
        public string Cedula { get; set; } = "";
        public string Hospital { get; set; } = "";
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string Motivo { get; set; } = "";
        public string Estado { get; set; } = "";
    }
}
