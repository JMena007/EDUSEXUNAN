using EDUSEX.conexion;
using EDUSEX.Controllers;
using EDUSEX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EDUSEX.Views
{
    public partial class FrmCitas : Form
    {
        // creacion de objetos para usar los control

        CitasControl citasControl = new CitasControl();
        UsuarioControl uControl = new UsuarioControl();
        private int idCita; // el sistema me lo exigio jaja
        private int idUsuarioSeleccionado; // guarda el usuario que trajo el buscador


        //cargar usuarios en el datagridview
        private void CargarCitas(CitasControl citasControl)
        {
            dgwCitas.DataSource = null;
            dgwCitas.DataSource = citasControl.CargarCitas();
        }

        public FrmCitas()
        {
            InitializeComponent();
        }

        // agregado: carga hospitales reales en el combo y las citas existentes al abrir el formulario
        private void FrmCitas_Load(object sender, EventArgs e)
        {
           /* using (var context = new EDUSEXContext())
            {
                hospitalesBindingSource.DataSource = context.Hospitales.ToList();
            }

            IPHospitales.DisplayMember = "NombreHospital";
            IPHospitales.ValueMember = "IdHospital";  */

            CargarCitas(citasControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Buscadortxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnagendarCita_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Busque y seleccione un usuario antes de agendar la cita.");
                return;
            }
            /*
            Hospitales hospitalSeleccionado = (Hospitales)IPHospitales.SelectedItem;

            if (hospitalSeleccionado == null)
            {
                MessageBox.Show("Seleccione un hospital.");
                return;
            }
            */
            Citas c = new Citas();
            {
                c.IdUsuario = idUsuarioSeleccionado;
                c.IdHospital = IPHospitales.TabIndex; // ya no TabIndex
                c.FechaCita = IPFecha.Value.ToString("yyyy-MM-dd");
                c.HoraCita = IPHoraCita.Value.ToString("HH:mm");
                c.Motivo = IPMotivocita.Text;
                c.Estado = IpEstado.Text;
                c.FechaRegistro = DateTime.Now;
            }
            ;

            citasControl.InsertarCita(c); // ahora se ejecuta ANTES de refrescar y avisar

            CargarCitas(citasControl);
            MessageBox.Show("Cita guardada correctamente.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = Buscadortxt.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show(".");
                return;
            }

            Usuarios usuario = uControl.BuscarPorCedulaONombre(searchValue);

            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado");
                idUsuarioSeleccionado = 0;
                return;
            }

            idUsuarioSeleccionado = usuario.IdUsuario;
            Nombretxt.Text = usuario.Nombres;
            Apellidotxt.Text = usuario.Apellidos;
            numEdad.Value = usuario.Edad;
            comboBox2.Text = usuario.Sexo;
        }

        private void btnCancelarcita_Click(object sender, EventArgs e)
        {
        }

        private void dgwCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (var context = new EDUSEXContext())
            {
                context.Citas.ToList();
            }
        }

        private void btnEliminarcita_Click(object sender, EventArgs e)
        {
            citasControl.EliminarCita(idCita);
        }

        private void btnEditarcita_Click(object sender, EventArgs e)
        {

            // me falto este evento no me dio tiempo
        }

        private void IPHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}