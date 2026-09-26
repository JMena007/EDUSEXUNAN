using EDUSEX;
using EDUSEX.conexion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EDUSEX.Views
{
    public partial class FrmHospitales : Form
    {
        public FrmHospitales()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmHospitales_Load(object sender, EventArgs e)
        {

        }

        
        private void dgwHospitales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using(var context = new EDUSEXContext())
            {
                
            }
        }
    }   
}
