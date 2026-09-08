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
    public partial class FrmHospitales : Form
    {
        public FrmHospitales()
        {
            InitializeComponent();

            btnInicio.Click += (sender, e) => NavigationHelper.Open<FormPrincipal>(this);
            button17.Click += (sender, e) => NavigationHelper.Open<FrmUsuario>(this);
            button16.Click += (sender, e) => NavigationHelper.Open<FrmHospital>(this);
            button15.Click += (sender, e) => NavigationHelper.Open<FrmHospitales>(this);
            button14.Click += (sender, e) => NavigationHelper.Open<FrmGuiaEducativa>(this);
            button11.Click += (sender, e) => NavigationHelper.Logout(this);
        }
    }
}
