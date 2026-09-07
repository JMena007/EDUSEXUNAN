using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDUSEX;

namespace EDUSEX.Views
{
    public partial class FrmHospital : Form
    {
        public FrmHospital()
        {
            InitializeComponent();

            button18.Click += (sender, e) => NavigationHelper.Open<FormPrincipal>(this);
            button17.Click += (sender, e) => NavigationHelper.Open<FrmUsuario>(this);
            button16.Click += (sender, e) => NavigationHelper.Open<FrmHospital>(this);
            button15.Click += (sender, e) => NavigationHelper.Open<FrmHospitales>(this);
            button14.Click += (sender, e) => NavigationHelper.Open<FrmGuiaEducativa>(this);
            button11.Click += (sender, e) => NavigationHelper.Logout(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Intentionally left empty for designer
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // TODO: implementar la acción para button12 (Guia Educativa)
        }

        private void Buscadortxt_TextChanged(object sender, EventArgs e)
        {
        }

        
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tb = sender as TextBox;
                string criterio = (tb != null) ? tb.Text.Trim() : string.Empty;
                MessageBox.Show("Simulando búsqueda de: " + criterio);
                e.SuppressKeyPress = true;
            }
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
