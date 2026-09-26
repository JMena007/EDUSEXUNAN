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

            using (var context = new EDUSEXContext())
            {
                // se uso diccionario para que no se viera los id feos sjjs
                var usuarios = context.Usuarios.ToDictionary(u => u.IdUsuario, u => u.Nombres + " " + u.Apellidos);
                var hospitales = context.Hospitales.ToDictionary(h => h.IdHospital, h => h.NombreHospital);

                var citasConNombres = citas.Select(c => new
                {
                    c.IdCita,
                    Paciente = usuarios.ContainsKey(c.IdUsuario) ? usuarios[c.IdUsuario] : "Desconocido",
                    Hospital = hospitales.ContainsKey(c.IdHospital) ? hospitales[c.IdHospital] : "Desconocido",
                    c.FechaCita,
                    c.HoraCita,
                    c.Motivo,
                    c.Estado
                }).ToList();

                dgwCitas.DataSource = null;
                dgwCitas.DataSource = citasConNombres;
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
            CargarCitas(citasControl);
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
            if (dgwCitas.CurrentRow == null) return;

            Citas citaSeleccionada = (Citas)dgwCitas.CurrentRow.DataBoundItem;
            idCita = citaSeleccionada.IdCita;
            idUsuarioSeleccionado = citaSeleccionada.IdUsuario;

            IPFecha.Value = citaSeleccionada.FechaCita;
            IPHoraCita.Value = DateTime.Today.Add(citaSeleccionada.HoraCita);
            IPMotivocita.Text = citaSeleccionada.Motivo;
            IpEstado.Text = citaSeleccionada.Estado;
            IPHospitales.SelectedValue = citaSeleccionada.IdHospital; 
        }

        //  Eliminar la cita seleccionada
        private void btnEliminarcita_Click(object sender, EventArgs e)
        {
            if (idCita == 0)
            {
                MessageBox.Show("Seleccione una cita para eliminar.");
                return;
            }

          DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la cita seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                citasControl.EliminarCita(idCita);
                CargarCitas(citasControl);
                LimpiarCampos();
            }
        }

        //  Guardar los cambios de la cita seleccionada 
        private void btnEditarcita_Click(object sender, EventArgs e)
        {
            if (idCita == 0)
            {
                MessageBox.Show("Seleccione una cita del listado para editar.");
                return;
            }

            if (IPHospitales.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un hospital.");
                return;
            }

            Citas c = new Citas
            {
                IdCita = idCita,
                IdUsuario = idUsuarioSeleccionado,
                IdHospital = Convert.ToInt32(IPHospitales.SelectedValue),
                FechaCita = IPFecha.Value.Date,
                HoraCita = IPHoraCita.Value.TimeOfDay,
                Motivo = IPMotivocita.Text,
                Estado = IpEstado.Text
            };

            citasControl.EditarCita(c);
            CargarCitas(citasControl);
            LimpiarCampos();
            MessageBox.Show("Cita actualizada correctamente.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       
    }
}