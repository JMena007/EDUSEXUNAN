using EDUSEX.Models;
using System.Collections.Generic;

namespace EDUSEX.Controllers
{
    internal class CitasControl
    {
        public void InsertarCita(Citas cita)
        {
            cita.InsertarCita();
        }

        public void EditarCita(Citas cita)
        {
            cita.EditarCita();
        }

        public void EliminarCita(int idCita)
        {
            Citas cita = Citas.ObtenerCitaPorId(idCita);
            cita?.EliminarCita();
        }

        public Citas ObtenerCitaPorId(int idCita)
        {
            return Citas.ObtenerCitaPorId(idCita);
        }

        public List<CitaReporte> ObtenerCitasPorUsuario(int idUsuario)
        {
            return Citas.CargarReportePorHospital(idUsuario);
        }

        public List<CitaReporte> CargarReportePorHospital(int idHospital)
        {
            return Citas.CargarReportePorHospital(idHospital);
        }
        public List<Citas> CargarCitas()
        {
            return Citas.CargarCitas();
        }
    }
}