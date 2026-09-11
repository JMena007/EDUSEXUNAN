using System;
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

        internal void PrepararLogin()
        {
            lnputUsertxt.Clear();
            inputContraseña.Clear();
            lnputUsertxt.PlaceholderText = "Correo@EDUSEX";
            inputContraseña.PlaceholderText = "Contraseña";
            linkInvitado.Visible = true;
            linkCreateCuenta.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkInvitado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formPrincipal == null || formPrincipal.IsDisposed)
            {
                formPrincipal = new FormPrincipal(this);
            }

            formPrincipal.Show();
            formPrincipal.Activate();
            Hide();
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

            FormPrincipal formPrincipal = new FormPrincipal();

            formPrincipal.Show();

            this.Hide();

            // Aquí vamos a validar el rol
        }
    }
    
}

