using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EDUSEX.Views
{
    public partial class Login : Form
    {
        private FormPrincipal? formPrincipal;

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
    }
}

