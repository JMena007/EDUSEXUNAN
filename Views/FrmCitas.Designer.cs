namespace EDUSEX.Views
{
    partial class FrmHospital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Buscadortxt = new TextBox();
            dgwCitas = new DataGridView();
            lbledad = new Label();
            lblnombre = new Label();
            llbapellidos = new Label();
            label6 = new Label();
            panelcita = new Panel();
            numEdad = new NumericUpDown();
            btnCancelarcita = new Button();
            IPEstado = new ComboBox();
            comboBox2 = new ComboBox();
            btnAgendarcita = new Button();
            label4 = new Label();
            Apellidotxt = new TextBox();
            Nombretxt = new TextBox();
            IPMotivocita = new ComboBox();
            lblmotivo = new Label();
            llbfecha = new Label();
            IPFecha = new DateTimePicker();
            IPHoraCita = new DateTimePicker();
            lblHospital = new Label();
            IPHospitales = new ComboBox();
            lblhora = new Label();
            label3 = new Label();
            btnEditarcita = new Button();
            btnEliminarcita = new Button();
            btnBuscar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgwCitas).BeginInit();
            panelcita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();
            // 
            // Buscadortxt
            // 
            Buscadortxt.Location = new Point(217, 23);
            Buscadortxt.Name = "Buscadortxt";
            Buscadortxt.PlaceholderText = "Buscar pacientes";
            Buscadortxt.Size = new Size(332, 23);
            Buscadortxt.TabIndex = 8;
            Buscadortxt.TextChanged += Buscadortxt_TextChanged;
            // 
            // dgwCitas
            // 
            dgwCitas.BackgroundColor = SystemColors.ButtonHighlight;
            dgwCitas.BorderStyle = BorderStyle.Fixed3D;
            dgwCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitas.Location = new Point(217, 325);
            dgwCitas.Name = "dgwCitas";
            dgwCitas.Size = new Size(579, 183);
            dgwCitas.TabIndex = 13;
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(10, 128);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 14;
            lbledad.Text = "Edad";
            lbledad.Click += label3_Click;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(10, 21);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 15;
            lblnombre.Text = "Nombre";
            // 
            // llbapellidos
            // 
            llbapellidos.AutoSize = true;
            llbapellidos.Location = new Point(10, 75);
            llbapellidos.Name = "llbapellidos";
            llbapellidos.Size = new Size(51, 15);
            llbapellidos.TabIndex = 16;
            llbapellidos.Text = "Apellido";
            llbapellidos.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 129);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 17;
            label6.Text = "Sexo";
            // 
            // panelcita
            // 
            panelcita.BackColor = SystemColors.ButtonFace;
            panelcita.BorderStyle = BorderStyle.Fixed3D;
            panelcita.Controls.Add(numEdad);
            panelcita.Controls.Add(btnCancelarcita);
            panelcita.Controls.Add(IPEstado);
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
            panelcita.Location = new Point(217, 54);
            panelcita.Name = "panelcita";
            panelcita.Size = new Size(570, 237);
            panelcita.TabIndex = 18;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(49, 123);
            numEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(69, 23);
            numEdad.TabIndex = 28;
            numEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // btnCancelarcita
            // 
            btnCancelarcita.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelarcita.ForeColor = SystemColors.ButtonFace;
            btnCancelarcita.Location = new Point(318, 183);
            btnCancelarcita.Name = "btnCancelarcita";
            btnCancelarcita.Size = new Size(80, 25);
            btnCancelarcita.TabIndex = 27;
            btnCancelarcita.Text = "Cancelar";
            btnCancelarcita.UseVisualStyleBackColor = false;
            // 
            // IPEstado
            // 
            IPEstado.FormattingEnabled = true;
            IPEstado.Items.AddRange(new object[] { "Confirmado", "Pendiente" });
            IPEstado.Location = new Point(510, 125);
            IPEstado.Name = "IPEstado";
            IPEstado.Size = new Size(42, 23);
            IPEstado.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            comboBox2.Location = new Point(173, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(50, 23);
            comboBox2.TabIndex = 21;
            // 
            // btnAgendarcita
            // 
            btnAgendarcita.BackColor = Color.PaleTurquoise;
            btnAgendarcita.Location = new Point(148, 183);
            btnAgendarcita.Name = "btnAgendarcita";
            btnAgendarcita.Size = new Size(80, 25);
            btnAgendarcita.TabIndex = 26;
            btnAgendarcita.Text = "Agendar Cita";
            btnAgendarcita.UseVisualStyleBackColor = false;
            btnAgendarcita.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 130);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 24;
            label4.Text = "Estado";
            label4.Click += label4_Click;
            // 
            // Apellidotxt
            // 
            Apellidotxt.Location = new Point(67, 68);
            Apellidotxt.Name = "Apellidotxt";
            Apellidotxt.Size = new Size(156, 23);
            Apellidotxt.TabIndex = 19;
            // 
            // Nombretxt
            // 
            Nombretxt.Location = new Point(67, 18);
            Nombretxt.Name = "Nombretxt";
            Nombretxt.Size = new Size(156, 23);
            Nombretxt.TabIndex = 18;
            // 
            // IPMotivocita
            // 
            IPMotivocita.FormattingEnabled = true;
            IPMotivocita.Items.AddRange(new object[] { "Personal", "Familiar", "Sexual", "Abuso" });
            IPMotivocita.Location = new Point(399, 122);
            IPMotivocita.Name = "IPMotivocita";
            IPMotivocita.Size = new Size(44, 23);
            IPMotivocita.TabIndex = 23;
            // 
            // lblmotivo
            // 
            lblmotivo.AutoSize = true;
            lblmotivo.Location = new Point(348, 129);
            lblmotivo.Name = "lblmotivo";
            lblmotivo.Size = new Size(45, 15);
            lblmotivo.TabIndex = 14;
            lblmotivo.Text = "Motivo";
            // 
            // llbfecha
            // 
            llbfecha.AutoSize = true;
            llbfecha.Location = new Point(291, 21);
            llbfecha.Name = "llbfecha";
            llbfecha.Size = new Size(38, 15);
            llbfecha.TabIndex = 16;
            llbfecha.Text = "Fecha";
            llbfecha.Click += label10_Click;
            // 
            // IPFecha
            // 
            IPFecha.Location = new Point(348, 15);
            IPFecha.Name = "IPFecha";
            IPFecha.Size = new Size(169, 23);
            IPFecha.TabIndex = 21;
            IPFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // IPHoraCita
            // 
            IPHoraCita.CustomFormat = "hh:mm tt";
            IPHoraCita.Format = DateTimePickerFormat.Custom;
            IPHoraCita.Location = new Point(281, 122);
            IPHoraCita.Name = "IPHoraCita";
            IPHoraCita.Size = new Size(48, 23);
            IPHoraCita.TabIndex = 22;
            IPHoraCita.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // lblHospital
            // 
            lblHospital.AutoSize = true;
            lblHospital.Location = new Point(291, 75);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new Size(51, 15);
            lblHospital.TabIndex = 15;
            lblHospital.Text = "Hospital";
            // 
            // IPHospitales
            // 
            IPHospitales.FormattingEnabled = true;
            IPHospitales.Location = new Point(348, 68);
            IPHospitales.Name = "IPHospitales";
            IPHospitales.Size = new Size(123, 23);
            IPHospitales.TabIndex = 21;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(242, 128);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(33, 15);
            lblhora.TabIndex = 17;
            lblhora.Text = "Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 304);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 20;
            label3.Text = "Citas Agendadas";
            // 
            // btnEditarcita
            // 
            btnEditarcita.BackColor = Color.LightSeaGreen;
            btnEditarcita.ForeColor = SystemColors.ButtonFace;
            btnEditarcita.Location = new Point(805, 368);
            btnEditarcita.Name = "btnEditarcita";
            btnEditarcita.Size = new Size(90, 30);
            btnEditarcita.TabIndex = 27;
            btnEditarcita.Text = "Editar";
            btnEditarcita.UseVisualStyleBackColor = false;
            // 
            // btnEliminarcita
            // 
            btnEliminarcita.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarcita.ForeColor = SystemColors.ButtonFace;
            btnEliminarcita.Location = new Point(805, 435);
            btnEliminarcita.Name = "btnEliminarcita";
            btnEliminarcita.Size = new Size(90, 30);
            btnEliminarcita.TabIndex = 28;
            btnEliminarcita.Text = "Eliminar";
            btnEliminarcita.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 180);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(555, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 25);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 525);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminarcita);
            Controls.Add(btnEditarcita);
            Controls.Add(label3);
            Controls.Add(panelcita);
            Controls.Add(dgwCitas);
            Controls.Add(Buscadortxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospital";
            Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)dgwCitas).EndInit();
            panelcita.ResumeLayout(false);
            panelcita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox IPEstado;
        private Button btnAgendarcita;
        private Button btnCancelarcita;
        private Button btnEditarcita;
        private Button btnEliminarcita;
        private Button btnBuscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown numEdad;
    }
}