using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDUSEX.Controllers;
using EDUSEX.Models;
using EDUSEX.conexion;
using System.Linq;

namespace EDUSEX.Views
{
    public partial class CreateUsernew : Form
    {
        public CreateUsernew()
        {
            InitializeComponent();
        }

        UsuarioControl usuarioControl = new UsuarioControl();

        CredencialControl CredencialControl = new CredencialControl();


        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(cmbSexo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (txtContraseña.Text != txtConfirmContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (usuarioControl.CedulaExiste(txtCedula.Text.Trim()))
            {
                MessageBox.Show("Ya existe un usuario registrado con esta cédula.");
                return;
            }

            // Crea el registro de datos personales
            var nuevoUsuario = new Usuarios
            {
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellido.Text.Trim(),
                Cedula = txtCedula.Text.Trim(),
                Edad = (int)nmEdad.Value,
                Sexo = cmbSexo.Text,
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            usuarioControl.InsertarUsuario(nuevoUsuario);

            // Trae el Id recién generado, para vincularlo a Credenciales
            Usuarios usuarioCreado = usuarioControl.BuscarPorCedulaONombre(nuevoUsuario.Cedula);

            // Crea el acceso — SIEMPRE rol Paciente (IdRol = 3), nunca elegido por el usuario (RF-02)
            Credenciales nuevaCredencial = new Credenciales()
            {
                IdUsuario = usuarioCreado.IdUsuario,
                NombreUsuario = txtCorreo.Text.Trim(),
                PasswordHash = txtContraseña.Text,
                IdRol = 3,
                Activo = true
            };

            CredencialControl c = new CredencialControl();
            c.InsertarCredencial(nuevaCredencial);

            MessageBox.Show("Cuenta creada exitosamente. Ya puede iniciar sesión.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //me retorna al formulario de login
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (login != null)
            {
                login.PrepararLogin();
                login.Show();
                login.Activate();
            }

            this.Close();

        }
    }
}
