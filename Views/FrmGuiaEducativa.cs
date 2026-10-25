using EDUSEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EDUSEX.Views
{
    public partial class FrmGuiaEducativa : Form
    {
        public FrmGuiaEducativa()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuiaEducativa_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.mined.gob.ni/biblioteca/wp-content/uploads/2024/07/Cartilla-1-secundaria-7a9.pdf";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string url = "https://www.mined.gob.ni/biblioteca/wp-content/uploads/2024/07/Cartilla-1-primara-1a4_man.pdf";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
