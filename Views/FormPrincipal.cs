using EDUSEX.Views;
using System.Drawing;

namespace EDUSEX
{
    public partial class FormPrincipal : Form
    {
        private readonly Panel panelContenido;

        public FormPrincipal()
        {
            InitializeComponent();

            SideMenuPanel.Controls.Clear();
            panel2.Controls.Remove(panel3);
            SideMenuPanel.Controls.Add(panel3);
            panel3.Dock = DockStyle.Fill;

            panelContenido = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SystemColors.ButtonHighlight
            };

            Controls.Add(panelContenido);
            panelContenido.SendToBack();

            Home.Click += button11_Click;
            button1BtnInicio.Click += button11_Click;
            button10.Visible = false;
            button11.Visible = true;
            panel4.Visible = true;
            button11.Click += button10_Click;
            button3.Click += button9_Click;
            button6.Click += btnUsuarios_Click;
            button5.Click += button9_Click;
            button1.Click += button8_Click;
            button17.Click += btnUsuarios_Click;
            button16.Click += button9_Click;
            button15.Click += button8_Click;
            button14.Click += button12_Click;
            button18.Click += button11_Click;

            MostrarInicio();
        }

        private void MostrarFormulario(Form formulario)
        {
            foreach (Control control in panelContenido.Controls)
            {
                control.Dispose();
            }

            panelContenido.Controls.Clear();

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
            foreach (Control control in panelContenido.Controls)
            {
                control.Dispose();
            }

            panelContenido.Controls.Clear();
            label1.Visible = true;
        }

        private static void OcultarMenuInterno(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control is Panel panel &&
                    (panel.Name == "panel2" || panel.Name == "panel3"))
                {
                    panel.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmUsuario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmHospitales());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmHospitales());
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmHospital());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmGuiaEducativa());
        }

        private void panelSeparador_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmUsuario());
        }
    }
}
