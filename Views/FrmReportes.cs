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
            CargarHospitales();
            MostrarMensaje("Seleccione un hospital para ver sus citas.");

            // Se conecta acá, después de llenar el combo, para que no se dispare al cargarlo
            cmbhos.SelectedIndexChanged += cmbHospital_SelectedIndexChanged;
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

            cmbHospital.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHospital.DataSource = lista;
            cmbHospital.DisplayMember = "NombreHospital";
            cmbHospital.ValueMember = "IdHospital";
        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbHospital.SelectedValue is int idHospital) || idHospital == 0)
            {
                MostrarMensaje("Seleccione un hospital para ver sus citas.");
                return;
            }

            List<CitaReporte> citas = citasControl.CargarReportePorHospital(idHospital);

            if (citas.Count == 0)
            {
                MostrarMensaje("Este hospital no tiene citas agendadas.");
                return;
            }

            lblMensaje.Text = "";
            dgwReporte.DataSource = citas;
            FormatearColumnas();

            int confirmadas = citas.Count(c => string.Equals(c.Estado, "Confirmado", StringComparison.OrdinalIgnoreCase));
            int pendientes = citas.Count(c => string.Equals(c.Estado, "Pendiente", StringComparison.OrdinalIgnoreCase));
            lblResumen.Text = $"Total: {citas.Count}   |   Confirmadas: {confirmadas}   |   Pendientes: {pendientes}";
        }

        private void MostrarMensaje(string texto)
        {
            dgwReporte.DataSource = null;
            lblMensaje.Text = texto;
            lblResumen.Text = "";
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
    }
}
