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
        private UsuarioControl usuarioControl = new UsuarioControl();

        private void CargarUsuarios()
        {
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
