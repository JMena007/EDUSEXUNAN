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
            lnputUsertxt.Clear();
            inputContraseña.Clear();
            lnputUsertxt.PlaceholderText = "Correo@EDUSEX";
            inputContraseña.PlaceholderText = "Contraseña";
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

            string usuario = lnputUsertxt.Text.Trim();
            string password = inputContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ingrese su usuario y contraseña.");
                return;
            }


            // aqui validamos con la funcion del controlador de credenciales para validar el login
            Credenciales credencial =
                credencialController.ValidarLogin(usuario, password);


            if (credencial == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Inicio de sesión correcto.");

            RolesControl rolesControl = new RolesControl();

//Asignamos mi shack
SesionActual.IdUsuarioLogueado = credencial.IdUsuario;
    SesionActual.NombreUsuario = credencial.NombreUsuario;
    SesionActual.RolUsuario = rolesControl.ObtenerNombreRol(credencial.IdRol);

            // aqui se le da acceso de´pues de validacion a FrmPrincipal
            FormPrincipal formPrincipal = new FormPrincipal();


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
    }

}

