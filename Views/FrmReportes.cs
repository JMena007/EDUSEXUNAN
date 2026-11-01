using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EDUSEX.Models;
using EDUSEX.Controllers;


namespace EDUSEX.Views
{
    public partial class FrmReportes : Form
    {
        CitasControl citasControl = new CitasControl();
        HospitalControl hospitalControl = new HospitalControl();

        public FrmReportes()
        {
            InitializeComponent();
            ConfigurarGrid();
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
        }

        private void ConfigurarGrid()
        {
            dgwReporte.ReadOnly = true;
            dgwReporte.AllowUserToAddRows = false;
            dgwReporte.AllowUserToDeleteRows = false;
            dgwReporte.RowHeadersVisible = false;
            dgwReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarHospitales()
        {
            List<Hospitales> lista = hospitalControl.ObtenerHospitales()
                                                    .Where(h => h.Estado)
                                                    .ToList();

            lista.Insert(0, new Hospitales { IdHospital = 0, NombreHospital = "-- Seleccione un hospital --" });

            cmbHospitales.DataSource = lista;
            cmbHospitales.DisplayMember = "NombreHospital";
            cmbHospitales.ValueMember = "IdHospital";
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            CargarHospitales();
        }

        private void cmbHospitales_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbHospitales.SelectedValue is not int idHospital || idHospital == 0)
            {
                dgwReporte.DataSource = null;
                return;
            }

            CargarReporte(idHospital);
        }

       

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cmbHospitales.SelectedValue is not int idHospital || idHospital == 0)
            {
                MessageBox.Show("Seleccione un hospital para generar el reporte.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CargarReporte(idHospital);
        }

        private void CargarReporte(int idHospital)
        {
            List<CitaReporte> citas = citasControl.CargarReportePorHospital(idHospital);

            dgwReporte.DataSource = citas;
            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            dgwReporte.Columns["IdCita"].Visible = false;
            dgwReporte.Columns["Hospital"].Visible = false; // redundante: ya lo elegiste en el combo
            dgwReporte.Columns["Cedula"].HeaderText = "Cédula";
            dgwReporte.Columns["FechaCita"].HeaderText = "Fecha";
            dgwReporte.Columns["FechaCita"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgwReporte.Columns["HoraCita"].HeaderText = "Hora";
            dgwReporte.Columns["HoraCita"].DefaultCellStyle.Format = @"hh\:mm";
        }

        private void dgwReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       
    }
}
