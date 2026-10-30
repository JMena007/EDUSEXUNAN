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
                try
                {
                    var citaExistente = context.Citas.FirstOrDefault(c => c.IdUsuario == this.IdUsuario && c.FechaCita.Date == this.FechaCita.Date && c.HoraCita == this.HoraCita);
                    if (citaExistente != null)
                    {
                        DialogResult result = MessageBox.Show("Ya existe una cita para este usuario en la misma fecha y hora. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }

                        context.Citas.Add(this);
                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
                
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
            try
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
            catch (Exception)
            {
               MessageBox.Show("No se puede eliminar la cita porque está siendo utilizada en otra parte del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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