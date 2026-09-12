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
            NavigationHelper.Open<FrmCitas>(this);
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
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Metodo editar
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

        // Nombres
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // Cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void boxsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sin alertas en tiempo real
        }

        // Validación centralizada: se llama SOLO al guardar/insertar/editar
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtnombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtapellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtapellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Ingrese la cédula.");
                txtCedula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el número de teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(boxsexo.Text))
            {
                MessageBox.Show("Seleccione una opción en Sexo.");
                boxsexo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                !txtCorreo.Text.Contains("@") ||
                !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo válido.");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            {
                u.Nombres = txtnombre.Text;
                u.Apellidos = txtapellido.Text;
                u.Cedula = txtCedula.Text;
                u.Edad = (int)numEdad.Value;
                u.Sexo = boxsexo.Text;
                u.Telefono = txtTelefono.Text;
                u.Correo = txtCorreo.Text;
            }
            ;

            if (idUsuarioEditando == null)
            {
                usuarioControl.InsertarUsuario(u);
            }

            else
            {
                u.IdUsuario = idUsuarioEditando.Value;
                usuarioControl.Editarusuario(u);
            }

            MessageBox.Show("Usuario guardado correctamente.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarUsuarios();
            
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
        
            if (dvgUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            Usuarios usuario = (Usuarios)dvgUsuarios.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar a {usuario.Nombres} {usuario.Apellidos}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                usuarioControl.EliminarUsuario(usuario.IdUsuario);
                CargarUsuarios(); 
                LimpiarCampos();
            }

        }
    }
    
}
