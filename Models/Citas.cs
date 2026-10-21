using EDUSEX.conexion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
            
        }


        public void InsertarCita()
        {
            using (var context = new EDUSEXContext())
            {
                context.Citas.Add(this);
                context.SaveChanges();
            }
        }

        public void EditarCita()
        {
            using (var context = new EDUSEXContext())
            {
                var citaExistente = context.Citas.AsNoTracking().FirstOrDefault(c => c.IdCita == this.IdCita);

                if (citaExistente != null && SesionActual.RolUsuario == "Paciente")
                {
                    this.Estado = citaExistente.Estado;
                }

                context.Citas.Update(this);
                context.SaveChanges();
            }
        }

        public void EliminarCita()
        {
            using (var context = new EDUSEXContext())
            {
                var cita = context.Citas.Find(this.IdCita);
                if (cita != null)
                {
                    context.Citas.Remove(cita);
                    context.SaveChanges();
                }
            }
        }

        public static Citas ObtenerCitaPorId(int idCita)
        {
            using (var context = new EDUSEXContext())
            {
                return context.Citas.FirstOrDefault(c => c.IdCita == idCita);
            }
        }

        public static List<Citas> CargarCitas()
        {
            using (var context = new EDUSEXContext())
            {
                return context.Citas.ToList();
            }
        }
    }
}