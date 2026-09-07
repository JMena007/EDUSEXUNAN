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
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkInvitado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPrincipal frmyes = new FormPrincipal();

            frmyes.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

