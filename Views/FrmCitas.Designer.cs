namespace EDUSEX.Views
{
    partial class FrmCitas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Buscadortxt = new TextBox();
            dgwCitas = new DataGridView();
            hospitalesBindingSource = new BindingSource(components);
            label3 = new Label();
            btnEditarcita = new Button();
            btnEliminarcita = new Button();
            btnBuscar = new Button();
            lblhora = new Label();
            IPHospitales = new ComboBox();
            lblHospital = new Label();
            IPHoraCita = new DateTimePicker();
            IPFecha = new DateTimePicker();
            llbfecha = new Label();
            llbapellidos = new Label();
            label6 = new Label();
            lbledad = new Label();
            lblnombre = new Label();
            lblmotivo = new Label();
            IPMotivocita = new ComboBox();
            Nombretxt = new TextBox();
            Apellidotxt = new TextBox();
            label4 = new Label();
            btnAgendarcita = new Button();
            comboBox2 = new ComboBox();
            IpEstado = new ComboBox();
            btnCancelarcita = new Button();
            numEdad = new NumericUpDown();
            btnActualizar = new Button();
            panel1 = new Panel();
            panelcita = new Panel();
            panel13 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgwCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hospitalesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            panelcita.SuspendLayout();
            SuspendLayout();
            // 
            // Buscadortxt
            // 
            Buscadortxt.Location = new Point(217, 23);
            Buscadortxt.Multiline = true;
            Buscadortxt.Name = "Buscadortxt";
            Buscadortxt.PlaceholderText = "Buscar Usuario o Paciente";
            Buscadortxt.Size = new Size(491, 35);
            Buscadortxt.TabIndex = 8;
            Buscadortxt.TextChanged += Buscadortxt_TextChanged;
            // 
            // dgwCitas
            // 
            dgwCitas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgwCitas.BackgroundColor = SystemColors.ButtonHighlight;
            dgwCitas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitas.Location = new Point(217, 352);
            dgwCitas.Name = "dgwCitas";
            dgwCitas.Size = new Size(600, 180);
            dgwCitas.TabIndex = 13;
            dgwCitas.CellContentClick += dgwCitas_CellContentClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 331);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 20;
            label3.Text = "Citas Agendadas";
            // 
            // btnEditarcita
            // 
            btnEditarcita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarcita.BackColor = Color.DarkOrchid;
            btnEditarcita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarcita.ForeColor = SystemColors.ButtonFace;
            btnEditarcita.Location = new Point(840, 384);
            btnEditarcita.Name = "btnEditarcita";
            btnEditarcita.Size = new Size(100, 43);
            btnEditarcita.TabIndex = 27;
            btnEditarcita.Text = "Editar";
            btnEditarcita.UseVisualStyleBackColor = false;
            btnEditarcita.Click += btnEditarcita_Click;
            // 
            // btnEliminarcita
            // 
            btnEliminarcita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarcita.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarcita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarcita.ForeColor = SystemColors.ButtonFace;
            btnEliminarcita.Location = new Point(840, 453);
            btnEliminarcita.Name = "btnEliminarcita";
            btnEliminarcita.Size = new Size(100, 42);
            btnEliminarcita.TabIndex = 28;
            btnEliminarcita.Text = "Eliminar";
            btnEliminarcita.UseVisualStyleBackColor = false;
            btnEliminarcita.Click += btnEliminarcita_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 180);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(748, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 35);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(293, 152);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(33, 15);
            lblhora.TabIndex = 17;
            lblhora.Text = "Hora";
            // 
            // IPHospitales
            // 
            IPHospitales.DataSource = hospitalesBindingSource;
            IPHospitales.FormattingEnabled = true;
            IPHospitales.Location = new Point(429, 103);
            IPHospitales.Name = "IPHospitales";
            IPHospitales.Size = new Size(247, 23);
            IPHospitales.TabIndex = 21;
            IPHospitales.SelectedIndexChanged += IPHospitales_SelectedIndexChanged;
            // 
            // lblHospital
            // 
            lblHospital.AutoSize = true;
            lblHospital.Location = new Point(429, 85);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new Size(51, 15);
            lblHospital.TabIndex = 15;
            lblHospital.Text = "Hospital";
            // 
            // IPHoraCita
            // 
            IPHoraCita.CustomFormat = " tt";
            IPHoraCita.Format = DateTimePickerFormat.Custom;
            IPHoraCita.Location = new Point(293, 170);
            IPHoraCita.Name = "IPHoraCita";
            IPHoraCita.Size = new Size(87, 23);
            IPHoraCita.TabIndex = 22;
            IPHoraCita.Value = new DateTime(2026, 9, 25, 23, 39, 13, 0);
            IPHoraCita.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // IPFecha
            // 
            IPFecha.Location = new Point(429, 34);
            IPFecha.Name = "IPFecha";
            IPFecha.Size = new Size(247, 23);
            IPFecha.TabIndex = 21;
            IPFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // llbfecha
            // 
            llbfecha.AutoSize = true;
            llbfecha.Location = new Point(429, 16);
            llbfecha.Name = "llbfecha";
            llbfecha.Size = new Size(38, 15);
            llbfecha.TabIndex = 16;
            llbfecha.Text = "Fecha";
            llbfecha.Click += label10_Click;
            // 
            // llbapellidos
            // 
            llbapellidos.AutoSize = true;
            llbapellidos.Location = new Point(67, 85);
            llbapellidos.Name = "llbapellidos";
            llbapellidos.Size = new Size(51, 15);
            llbapellidos.TabIndex = 16;
            llbapellidos.Text = "Apellido";
            llbapellidos.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 152);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 17;
            label6.Text = "Sexo";
            // 
            // lbledad
            // 
            lbledad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbledad.AutoSize = true;
            lbledad.Location = new Point(39, 152);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 14;
            lbledad.Text = "Edad";
            lbledad.Click += label3_Click;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(67, 19);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 15;
            lblnombre.Text = "Nombre";
            // 
            // lblmotivo
            // 
            lblmotivo.AutoSize = true;
            lblmotivo.Location = new Point(444, 152);
            lblmotivo.Name = "lblmotivo";
            lblmotivo.Size = new Size(45, 15);
            lblmotivo.TabIndex = 14;
            lblmotivo.Text = "Motivo";
            // 
            // IPMotivocita
            // 
            IPMotivocita.FormattingEnabled = true;
            IPMotivocita.Items.AddRange(new object[] { "Personal", "Familiar", "Sexual", "Abuso" });
            IPMotivocita.Location = new Point(444, 172);
            IPMotivocita.Name = "IPMotivocita";
            IPMotivocita.Size = new Size(70, 23);
            IPMotivocita.TabIndex = 23;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(67, 37);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(249, 23);
            Nombretxt.TabIndex = 18;
            Nombretxt.TextChanged += Nombretxt_TextChanged;
            // 
            // Apellidotxt
            // 
            Apellidotxt.Location = new Point(67, 103);
            Apellidotxt.Name = "Apellidotxt";
            Apellidotxt.Size = new Size(249, 23);
            Apellidotxt.TabIndex = 19;
            Apellidotxt.TextChanged += Apellidotxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 152);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 24;
            label4.Text = "Estado";
            label4.Click += label4_Click;
            // 
            // btnAgendarcita
            // 
            btnAgendarcita.BackColor = Color.DarkOrchid;
            btnAgendarcita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendarcita.ForeColor = SystemColors.ControlLightLight;
            btnAgendarcita.Location = new Point(128, 212);
            btnAgendarcita.Name = "btnAgendarcita";
            btnAgendarcita.Size = new Size(100, 39);
            btnAgendarcita.TabIndex = 26;
            btnAgendarcita.Text = "Agendar Cita";
            btnAgendarcita.UseVisualStyleBackColor = false;
            btnAgendarcita.Click += btnagendarCita_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            comboBox2.Location = new Point(157, 170);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(86, 23);
            comboBox2.TabIndex = 21;
            // 
            // IpEstado
            // 
            IpEstado.FormattingEnabled = true;
            IpEstado.Items.AddRange(new object[] { "Confirmado", "Pendiente" });
            IpEstado.Location = new Point(581, 172);
            IpEstado.Name = "IpEstado";
            IpEstado.Size = new Size(77, 23);
            IpEstado.TabIndex = 25;
            // 
            // btnCancelarcita
            // 
            btnCancelarcita.BackColor = Color.Gray;
            btnCancelarcita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarcita.ForeColor = Color.White;
            btnCancelarcita.Location = new Point(320, 212);
            btnCancelarcita.Name = "btnCancelarcita";
            btnCancelarcita.RightToLeft = RightToLeft.No;
            btnCancelarcita.Size = new Size(100, 39);
            btnCancelarcita.TabIndex = 27;
            btnCancelarcita.Text = "Limpiar";
            btnCancelarcita.UseVisualStyleBackColor = false;
            btnCancelarcita.Click += btnCancelarcita_Click;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(39, 170);
            numEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(70, 23);
            numEdad.TabIndex = 28;
            numEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numEdad.ValueChanged += numEdad_ValueChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.MediumPurple;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(501, 212);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 39);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 89, 182);
            panel1.Location = new Point(67, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 2);
            panel1.TabIndex = 31;
            // 
            // panelcita
            // 
            panelcita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelcita.BackColor = SystemColors.ButtonFace;
            panelcita.BorderStyle = BorderStyle.Fixed3D;
            panelcita.Controls.Add(panel13);
            panelcita.Controls.Add(panel12);
            panelcita.Controls.Add(panel11);
            panelcita.Controls.Add(panel10);
            panelcita.Controls.Add(panel9);
            panelcita.Controls.Add(panel8);
            panelcita.Controls.Add(panel7);
            panelcita.Controls.Add(panel6);
            panelcita.Controls.Add(panel1);
            panelcita.Controls.Add(btnActualizar);
            panelcita.Controls.Add(numEdad);
            panelcita.Controls.Add(btnCancelarcita);
            panelcita.Controls.Add(IpEstado);
            panelcita.Controls.Add(comboBox2);
            panelcita.Controls.Add(btnAgendarcita);
            panelcita.Controls.Add(label4);
            panelcita.Controls.Add(Apellidotxt);
            panelcita.Controls.Add(Nombretxt);
            panelcita.Controls.Add(IPMotivocita);
            panelcita.Controls.Add(lblmotivo);
            panelcita.Controls.Add(lblnombre);
            panelcita.Controls.Add(lbledad);
            panelcita.Controls.Add(label6);
            panelcita.Controls.Add(llbapellidos);
            panelcita.Controls.Add(llbfecha);
            panelcita.Controls.Add(IPFecha);
            panelcita.Controls.Add(IPHoraCita);
            panelcita.Controls.Add(lblHospital);
            panelcita.Controls.Add(IPHospitales);
            panelcita.Controls.Add(lblhora);
            panelcita.Location = new Point(217, 64);
            panelcita.Name = "panelcita";
            panelcita.Size = new Size(711, 264);
            panelcita.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(159, 89, 182);
            panel13.Location = new Point(581, 193);
            panel13.Name = "panel13";
            panel13.Size = new Size(75, 2);
            panel13.TabIndex = 39;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(159, 89, 182);
            panel12.Location = new Point(445, 193);
            panel12.Name = "panel12";
            panel12.Size = new Size(69, 2);
            panel12.TabIndex = 38;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(159, 89, 182);
            panel11.Location = new Point(159, 191);
            panel11.Name = "panel11";
            panel11.Size = new Size(80, 2);
            panel11.TabIndex = 37;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(159, 89, 182);
            panel10.Location = new Point(293, 191);
            panel10.Name = "panel10";
            panel10.Size = new Size(88, 2);
            panel10.TabIndex = 36;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(159, 89, 182);
            panel9.Location = new Point(40, 191);
            panel9.Name = "panel9";
            panel9.Size = new Size(69, 2);
            panel9.TabIndex = 35;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(159, 89, 182);
            panel8.Location = new Point(429, 124);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 2);
            panel8.TabIndex = 34;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(159, 89, 182);
            panel7.Location = new Point(429, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(247, 2);
            panel7.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(159, 89, 182);
            panel6.Location = new Point(69, 58);
            panel6.Name = "panel6";
            panel6.Size = new Size(247, 2);
            panel6.TabIndex = 32;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 530);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminarcita);
            Controls.Add(btnEditarcita);
            Controls.Add(label3);
            Controls.Add(panelcita);
            Controls.Add(dgwCitas);
            Controls.Add(Buscadortxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCitas";
            Text = "Citas";
            Load += FrmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)hospitalesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            panelcita.ResumeLayout(false);
            panelcita.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancelarcita_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Nombretxt_TextChanged(object sender, EventArgs e)
        {
            
        }


        #endregion
        private TextBox Buscadortxt;
        private DataGridView dgwCitas;
        private Label lbledad;
        private Label lblnombre;
        private Label llbapellidos;
        private Label label6;
        private Panel panelcita;
        private Label lblHospital;
        private Label lblmotivo;
        private Label lblhora;
        private Label llbfecha;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox Apellidotxt;
        private TextBox Nombretxt;
        private DateTimePicker IPFecha;
        private ComboBox IPHospitales;
        private Label label4;
        private ComboBox IPMotivocita;
        private DateTimePicker IPHoraCita;
        private ComboBox IpEstado;
        private Button btnAgendarcita;
        private Button btnCancelarcita;
        private Button btnEditarcita;
        private Button btnEliminarcita;
        private Button btnBuscar;
        private NumericUpDown numEdad;
        private BindingSource hospitalesBindingSource;
        private Button btnActualizar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
    }
}