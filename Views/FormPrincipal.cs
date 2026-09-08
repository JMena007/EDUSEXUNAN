using EDUSEX.Views;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace EDUSEX
{
    public partial class FormPrincipal : Form
    {
        private readonly Panel panelContenido;
        private readonly Login? login;

        public FormPrincipal() : this(Application.OpenForms.OfType<Login>().FirstOrDefault())
        {
        }

        public FormPrincipal(Login? login)
        {
            InitializeComponent();
            this.login = login;

            panelContenido = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SystemColors.ButtonHighlight
            };

            Controls.Add(panelContenido);
            panelContenido.BringToFront();
            panel3.BringToFront();
            label1.BringToFront();
            btnSoporte.Visible = true;

            btnInicio.Click += (sender, e) => MostrarInicio();
            button3.Click += (sender, e) => MostrarFormulario(new FrmUsuario());
            btnCitas.Click += (sender, e) => MostrarFormulario(new FrmHospital());
            btnHospitales.Click += (sender, e) => MostrarFormulario(new FrmHospitales());
            // El control en el diseñador se llama "btnCloseSesion". Usar ese nombre aquí.
            btnCloseSesion.Click += btnCloseSesion_Click;

            MostrarInicio();
        }

        private void MostrarFormulario(Form formulario)
        {
            LimpiarContenido();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            OcultarMenuInterno(formulario);

            label1.Visible = false;
            panelContenido.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
        }

        private void MostrarInicio()
        {
            LimpiarContenido();
            label1.Visible = true;
            label1.BringToFront();
        }

        private void LimpiarContenido()
        {
            foreach (Control control in panelContenido.Controls)
            {
                control.Dispose();
            }

            panelContenido.Controls.Clear();
        }

        private static void OcultarMenuInterno(Form formulario)
        {
            int anchoMenu = 0;

            foreach (Control control in formulario.Controls)
            {
                if (control is Panel panel &&
                    (panel.Name == "panel2" || panel.Name == "panel3"))
                {
                    anchoMenu = panel.Width;
                    panel.Visible = false;
                    break;
                }
            }

            foreach (Control control in formulario.Controls)
            {
                if (anchoMenu > 0 && control.Visible && control.Left >= anchoMenu)
                {
                    control.Left -= anchoMenu;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmHospital());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            string telefono = "50587762490";
            string mensaje = "Hola, Necesito apoyo con el sistema EDUSEX";
            string url = $"https://wa.me/{telefono}?text={Uri.EscapeDataString(mensaje)}";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            if (login is null)
            {
                Application.Exit();
                return;
            }

            login.PrepararLogin();
            login.Show();
            login.Activate();
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuiaEdu_Click(object sender, EventArgs e)
        {

        }
    }
}