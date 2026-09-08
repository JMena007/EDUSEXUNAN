using EDUSEX.Views;

namespace EDUSEX
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            Home.Click += button11_Click;
            button3.Click += button9_Click;
            button5.Click += button9_Click;
            button6.Click += btnUsuarios_Click;
            btnHospitales.Click += button8_Click;
            button10.Click += button10_Click;
            button11.Click += button10_Click;
            button14.Click += button12_Click;
            button15.Click += button8_Click;
            button16.Click += button9_Click;
            button17.Click += btnUsuarios_Click;
            button18.Click += button11_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmUsuario>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmHospitales>(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmHospitales>(this);
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmHospital>(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmGuiaEducativa>(this);
        }

        private void panelSeparador_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open<FrmUsuario>(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}