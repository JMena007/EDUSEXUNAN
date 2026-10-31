using EDUSEX.Models;
using System.Collections.Generic;

namespace EDUSEX.Controllers
{
    internal class HospitalControl
    {
        public List<Hospitales> ObtenerHospitales()
        {
            return Hospitales.ObtenerHospitales();
        }

        public void MostrarCitasHospitales(Hospitales hospital, Citas citas)
        {
            hospital?.MostrarCitasHospitales(citas);
        }
    }
}
