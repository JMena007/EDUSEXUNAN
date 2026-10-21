using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDUSEX.Controllers;
using EDUSEX.Models;


namespace EDUSEX.Views
{
    public partial class Login : Form
    {
        private FormPrincipal? formPrincipal;

        private CredencialControl credencialController = new CredencialControl();

        public Login()
        {
            InitializeComponent();
            PrepararLogin();
        }

        //metodo de validacion 
        internal void PrepararLogin()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            linkCreateCuenta.Visible = true;
        }

        private void CampoTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lnputUsertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ingrese su usuario y contraseña.");
                txtUsuario.Focus();
                return;
            }

            Credenciales credencial = credencialController.ValidarLogin(usuario, password);

            if (credencial == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Inicio de sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioControl usuarioControl = new UsuarioControl();
            Usuarios usuarioLogueado = usuarioControl.ObtenerUsuarioPorId(credencial.IdUsuario);

            RolesControl rolesControl = new RolesControl();

            SesionActual.IdUsuarioLogueado = credencial.IdUsuario;
            SesionActual.NombreUsuario = credencial.NombreUsuario;
            SesionActual.RolUsuario = rolesControl.ObtenerNombreRol(usuarioLogueado.IdRol);

            FormPrincipal formPrincipal = new FormPrincipal(this);
            formPrincipal.Show();
            this.Hide();
        }

        private void inputContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCreateCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUsernew createUserForm = new CreateUsernew();

            createUserForm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

