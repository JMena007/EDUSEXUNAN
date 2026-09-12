using EDUSEX.conexion;
using EDUSEX.Controllers;
using EDUSEX.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace EDUSEX.Views
{
    public partial class FrmUsuario : Form
    {

        // creando objeto de controlador
        private UsuarioControl usuarioControl = new UsuarioControl();
        private int? idUsuarioEditando = null;
        private void CargarUsuarios()
        {
            dvgUsuarios.DataSource = null;
            dvgUsuarios.DataSource = usuarioControl.ObtenerUsuarios();
        }
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button1BtnInicio_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FormPrincipal>(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmHospitales>(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmHospital>(this);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // TODO: implementar acción para btnsoporte (Soporte IT)
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // etiqueta informativa, no necesita acción
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // etiqueta informativa, no necesita acción
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

            CargarUsuarios();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            Usuarios usuario = (Usuarios)dvgUsuarios.CurrentRow.DataBoundItem;

            idUsuarioEditando = usuario.IdUsuario;

            txtnombre.Text = usuario.Nombres;
            txtapellido.Text = usuario.Apellidos;
            txtCedula.Text = usuario.Cedula;
            numEdad.Value = usuario.Edad;
            boxsexo.Text = usuario.Sexo;
            txtTelefono.Text = usuario.Telefono;
            txtCorreo.Text = usuario.Correo;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtnombre.Focus();
                return;
            }
            if (!char.IsLetter(e.KeyChar) &&
                  !char.IsControl(e.KeyChar) &&
                  e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtapellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtapellido.Focus();
                return;
            }
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                 e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el número de teléfono.");
                txtTelefono.Focus();
                return;
            }
            txtTelefono.Mask = "0000-0000";
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Ingrese la cédula.");
                txtCedula.Focus();
                return;
            }
            if (!char.IsDigit(e.KeyChar) &&
              !char.IsControl(e.KeyChar) &&
              e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese el correo electrónico.");
                txtCorreo.Focus();
                return;
            }

            if (!txtCorreo.Text.Contains("@") ||
              !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo válido.");
                txtCorreo.Focus();
                return;
            }
        }

        private void boxsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxsexo.Text))
            {
                MessageBox.Show("Seleccione una opción en Sexo.");
               boxsexo.Focus();
               return;
            }
        }
    }
}
