using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using EDUSEX.Models;
using EDUSEX.Controllers;

namespace EDUSEX.Views
{
    public partial class FrmReportes : Form
    {
        CitasControl citasControl = new CitasControl();
        HospitalControl hospitalControl = new HospitalControl();
        private List<DataGridViewColumn> columnasImpresion = new();
        private List<DataGridViewRow> filasImpresion = new();
        private int filaActual;

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
            if (dgwReporte.Rows.Count == 0 || dgwReporte.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
            {
                MessageBox.Show("No hay citas para imprimir.", "EDUSEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PrepararDatosParaImpresion();

                using PrintDocument documento = new PrintDocument();
                documento.DefaultPageSettings.Landscape = true;
                documento.BeginPrint += Documento_BeginPrint;
                documento.PrintPage += Documento_PrintPage;

                using PrintDialog dialogoImpresion = new PrintDialog
                {
                    Document = documento,
                    UseEXDialog = true,
                    AllowSomePages = true,
                    AllowSelection = false
                };

                if (dialogoImpresion.ShowDialog(this) == DialogResult.OK)
                {
                    documento.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo preparar la vista previa de impresión.\nDetalle: {ex.Message}",
                    "Error de impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrepararDatosParaImpresion()
        {
            columnasImpresion = dgwReporte.Columns
                .Cast<DataGridViewColumn>()
                .Where(columna => columna.Visible)
                .OrderBy(columna => columna.DisplayIndex)
                .ToList();

            filasImpresion = dgwReporte.Rows
                .Cast<DataGridViewRow>()
                .Where(fila => !fila.IsNewRow)
                .ToList();

            filaActual = 0;
        }

        private void Documento_BeginPrint(object? sender, PrintEventArgs e)
        {
            filaActual = 0;
        }

        private void Documento_PrintPage(object? sender, PrintPageEventArgs e)
        {
            const int altoFila = 28;
            int anchoTabla = e.MarginBounds.Width;
            int anchoColumna = Math.Max(1, anchoTabla / Math.Max(columnasImpresion.Count, 1));
            int posicionY = e.MarginBounds.Top;

            using Font titulo = new Font("Arial", 14, FontStyle.Bold);
            using Font texto = new Font("Arial", 8);
            using Font encabezado = new Font("Arial", 8, FontStyle.Bold);
            using StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            e.Graphics.DrawString("Reporte de citas por hospital", titulo, Brushes.Black, e.MarginBounds.Left, posicionY);
            posicionY += 28;
            e.Graphics.DrawString($"Hospital: {cmbHospitales.Text}", texto, Brushes.Black, e.MarginBounds.Left, posicionY);
            posicionY += 18;
            e.Graphics.DrawString($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}", texto, Brushes.Black, e.MarginBounds.Left, posicionY);
            posicionY += 28;

            int posicionX = e.MarginBounds.Left;

            foreach (DataGridViewColumn columna in columnasImpresion)
            {
                Rectangle rectangulo = new Rectangle(posicionX, posicionY, anchoColumna, altoFila);
                e.Graphics.FillRectangle(Brushes.LightGray, rectangulo);
                e.Graphics.DrawRectangle(Pens.Gray, rectangulo);
                e.Graphics.DrawString(columna.HeaderText, encabezado, Brushes.Black, rectangulo, formato);
                posicionX += anchoColumna;
            }

            posicionY += altoFila;

            while (filaActual < filasImpresion.Count)
            {
                if (posicionY + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                DataGridViewRow fila = filasImpresion[filaActual];
                posicionX = e.MarginBounds.Left;

                foreach (DataGridViewColumn columna in columnasImpresion)
                {
                    Rectangle rectangulo = new Rectangle(posicionX, posicionY, anchoColumna, altoFila);
                    e.Graphics.DrawRectangle(Pens.Gray, rectangulo);
                    e.Graphics.DrawString(ObtenerTextoCelda(fila.Cells[columna.Index].Value), texto, Brushes.Black, rectangulo, formato);
                    posicionX += anchoColumna;
                }

                posicionY += altoFila;
                filaActual++;
            }

            e.HasMorePages = false;
        }

        private static string ObtenerTextoCelda(object? valor)
        {
            if (valor is null || valor == DBNull.Value)
            {
                return string.Empty;
            }

            return valor switch
            {
                DateTime fecha => fecha.ToString("dd/MM/yyyy"),
                TimeSpan hora => hora.ToString(@"hh\:mm"),
                _ => valor.ToString() ?? string.Empty
            };
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
            dgwReporte.Columns["Hospital"].Visible = false;
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
