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

            PanelNav.BringToFront();
            label1.BringToFront();
            ImgEdusex.BringToFront();
            btnSoporte.Visible = true;


            btnInicio.Click += (sender, e) => { MostrarInicio(); };

            button3.Click += (sender, e) =>
            {
                MostrarFormulario(new FrmUsuario());
            };

            btnCitas.Click += (sender, e) =>
            {
                FrmCitas frmCitas = new FrmCitas();

                frmCitas.SolicitudIrAUsuarios += () =>
                {
                    MostrarFormulario(new FrmUsuario());
                };

                MostrarFormulario(frmCitas);
            };

            btnHospitales.Click += (sender, e) =>
            {
                MostrarFormulario(new FrmHospitales());
            };

            btnGuiaEdu.Click += (sender, e) =>
            {
                MostrarFormulario(new FrmGuiaEducativa());
            };


            ConfigurarSidebarPorRol();

            MostrarInicio();
        }

        private void ConfigurarSidebarPorRol()
        {
            if (SesionActual.RolUsuario == "Paciente")
            {
                button3.Visible = false;
                btnHospitales.Visible = false;
            }
        }

        private void MostrarFormulario(Form formulario)
        {
            LimpiarContenido();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            OcultarMenuInterno(formulario);

            label1.Visible = false;

            ImgEdusex.Visible = false;

            panelContenido.Controls.Add(formulario);

            formulario.Show();

            formulario.BringToFront();
        }

        private void MostrarInicio()
        {
            LimpiarContenido();

            label1.Visible = true;
            
            label1.BringToFront();

            ImgEdusex.Visible = true;
            ImgEdusex.BringToFront();

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
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
             
          DialogResult result = MessageBox.Show("Quieres Contactar a Soporte IT ?.", "Información", MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                string telefono = "50586953946";
                string mensaje = "Hola, Necesito apoyo con el sistema EDUSEX";
                string url = $"https://wa.me/{telefono}?text={Uri.EscapeDataString(mensaje)}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
             
            DialogResult result = MessageBox.Show("Seguro que quieres cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                if (login is null)
                {
                    Application.Exit();
                    return;
                }
            }
            

            login.PrepararLogin();
            login.Show();
            login.Activate();
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }


        private void btnGuiaEdu_Click(object sender, EventArgs e)
        {
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnHospitales_Click(object sender, EventArgs e)
        {
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}