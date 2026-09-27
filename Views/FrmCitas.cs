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
        CitasControl citasControl = new CitasControl();
        UsuarioControl userControl = new UsuarioControl();
        private int idCita;
        private int idUsuarioSeleccionado;

        public event Action SolicitudIrAUsuarios;


        private void CargarCitas(CitasControl citasControl)
        {
            List<Citas> citas = citasControl.CargarCitas();

            if (SesionActual.RolUsuario == "Paciente")
            {
                citas = citas.Where(c => c.IdUsuario == SesionActual.IdUsuarioLogueado).ToList();
            }

            using (var context = new EDUSEXContext())
            {
                var usuarios = context.Usuarios.ToDictionary(u => u.IdUsuario, u => u.Nombres + " " + u.Apellidos);
                var hospitales = context.Hospitales.ToDictionary(h => h.IdHospital, h => h.NombreHospital);

                var citasConNombres = citas.Select(c => new
                {
                    c.IdCita,
                    c.IdUsuario,
                    c.IdHospital,
                    Paciente = usuarios.ContainsKey(c.IdUsuario) ? usuarios[c.IdUsuario] : "Desconocido",
                    Hospital = hospitales.ContainsKey(c.IdHospital) ? hospitales[c.IdHospital] : "Desconocido",
                    c.FechaCita,
                    c.HoraCita,
                    c.Motivo,
                    c.Estado
                }).ToList();

                dgwCitas.DataSource = null;
                dgwCitas.DataSource = citasConNombres;

                if (dgwCitas.Columns["IdUsuario"] != null) dgwCitas.Columns["IdUsuario"].Visible = false;
                if (dgwCitas.Columns["IdHospital"] != null) dgwCitas.Columns["IdHospital"].Visible = false;
            }
        }

        public FrmCitas()
        {
            InitializeComponent();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            using (var context = new EDUSEXContext())
            {
                hospitalesBindingSource.DataSource = context.Hospitales.ToList();
            }

            IPHospitales.DataSource = hospitalesBindingSource;
            IPHospitales.DisplayMember = "NombreHospital";
            IPHospitales.ValueMember = "IdHospital";

            ConfigurarPorRol();
            CargarCitas(citasControl);
        }

        private void ConfigurarPorRol()
        {
            if (SesionActual.RolUsuario == "Paciente")
            {
                Buscadortxt.Visible = false;
                btnBuscar.Visible = false;

                
                idUsuarioSeleccionado = SesionActual.IdUsuarioLogueado;
            }
            else
            {
                Buscadortxt.Visible = true;
                btnBuscar.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void button12_Click(object sender, EventArgs e) { }
        private void Buscadortxt_TextChanged(object sender, EventArgs e) { }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        //  Agendar cita nueva 
        private void btnagendarCita_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Busque y seleccione un usuario antes de agendar la cita.");
                return;
            }

            if (IPHospitales.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un hospital.");
                return;
            }

            Citas c = new Citas
            {
                IdUsuario = idUsuarioSeleccionado,
                IdHospital = Convert.ToInt32(IPHospitales.SelectedValue),
                FechaCita = IPFecha.Value.Date,
                HoraCita = IPHoraCita.Value.TimeOfDay,
                Motivo = IPMotivocita.Text,
                Estado = IpEstado.Text,
                FechaRegistro = DateTime.Now
            };

            citasControl.InsertarCita(c);

            CargarCitas(citasControl);
            LimpiarCampos();
            MessageBox.Show("Cita guardada correctamente.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }

        //  Buscar usuario por cédula o nombre 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarValue = Buscadortxt.Text.Trim();

            if (string.IsNullOrEmpty(buscarValue))
            {
                MessageBox.Show("Ingrese cédula o nombre para buscar.");
                return;
            }

            Usuarios usuario = userControl.BuscarPorCedulaONombre(buscarValue);

            if (usuario == null)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Usuario no encontrado. ¿Desea registrarlo ahora?",
                    "Usuario no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    SolicitudIrAUsuarios?.Invoke();
                }

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
            LimpiarCampos();
        }


        private void dgwCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //  Eliminar la cita seleccionada
        private void btnEliminarcita_Click(object sender, EventArgs e)
        {
            if (dgwCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita del listado para editar.");
                return;
            }

            int id = Convert.ToInt32(
                dgwCitas.CurrentRow.Cells["IdCita"].Value
            );

            Citas citaSeleccionada = citasControl.ObtenerCitaPorId(id);

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la cita seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                citasControl.EliminarCita(id);
                CargarCitas(citasControl);
                LimpiarCampos();
            }
        }

        //  Guardar los cambios de la cita seleccionada 
        private void btnEditarcita_Click(object sender, EventArgs e)
        {
            if (dgwCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita del listado para editar.");
                return;
            }

            int id = Convert.ToInt32(
                dgwCitas.CurrentRow.Cells["IdCita"].Value
            );

            Citas citaSeleccionada = citasControl.ObtenerCitaPorId(id);

            if (citaSeleccionada == null)
            {
                MessageBox.Show("No se encontró la cita.");
                return;
            }

            idCita = citaSeleccionada.IdCita;
            idUsuarioSeleccionado = citaSeleccionada.IdUsuario;

            IPFecha.Value = citaSeleccionada.FechaCita;
            IPHoraCita.Value = DateTime.Today.Add(citaSeleccionada.HoraCita);
            IPMotivocita.Text = citaSeleccionada.Motivo;
            IpEstado.Text = citaSeleccionada.Estado;
            IPHospitales.SelectedValue = citaSeleccionada.IdHospital;

            Usuarios usuario = userControl.ObtenerUsuarioPorId(citaSeleccionada.IdUsuario);

            if (usuario != null)
            {
                Nombretxt.Text = usuario.Nombres;
                Apellidotxt.Text = usuario.Apellidos;
                numEdad.Value = usuario.Edad;
                comboBox2.Text = usuario.Sexo;
            }

            citasControl.EditarCita(citaSeleccionada);
        }

        private void IPHospitales_SelectedIndexChanged(object sender, EventArgs e) { }

        private void LimpiarCampos()
        {
            idCita = 0;
            idUsuarioSeleccionado = 0;
            Buscadortxt.Clear();
            Nombretxt.Clear();
            Apellidotxt.Clear();
            numEdad.Value = numEdad.Minimum;
            comboBox2.SelectedIndex = -1;
            IPHospitales.SelectedIndex = -1;
            IPMotivocita.SelectedIndex = -1;
            IpEstado.SelectedIndex = -1;
            IPFecha.Value = DateTime.Now;
            IPHoraCita.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Apellidotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}