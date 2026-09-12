using EDUSEX.conexion;
using EDUSEX.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUSEX.Controllers
{
    internal class CitasControl
    {

        public void InsertarCita(Models.Citas cita)
        {
            using (EDUSEX.conexion.EDUSEXContext context = new EDUSEX.conexion.EDUSEXContext())
            {
                context.Citas.Add(cita);
                context.SaveChanges();
            }
        } 

        public void EditarCita(Models.Citas cita)
        {
            using ( EDUSEX.conexion.EDUSEXContext context = new EDUSEX.conexion.EDUSEXContext())
            {
                context.Citas.Update(cita);
                context.SaveChanges();
            }
        }

        public void EliminarCita(int idCita)
        {
            using (EDUSEX.conexion.EDUSEXContext context = new EDUSEX.conexion.EDUSEXContext())
            {
                var cita = context.Citas.Find(idCita);
                if (cita != null)
                {
                    context.Citas.Remove(cita);
                    context.SaveChanges();
                }
            }
        }


        public List<Models.Citas> ObtenerCitas()
        {
            using (EDUSEXContext context = new EDUSEXContext())
            {
                return context.Citas.ToList();
            }
        }

    }

}
       