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
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            button11 = new Button();
            panel4 = new Panel();
            btnsoporte = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            dgwCitas = new DataGridView();
            lbledad = new Label();
            lblnombre = new Label();
            llbapellidos = new Label();
            label6 = new Label();
            panelcita = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelcita2 = new Panel();
            button1 = new Button();
            btnAgendacita = new Button();
            panelestado = new ComboBox();
            label4 = new Label();
            panelmotivodecita = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            lblHospital = new Label();
            lblmotivo = new Label();
            lblhora = new Label();
            llbfecha = new Label();
            label3 = new Label();
            btnEditarcita = new Button();
            btnEliminarcita = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCitas).BeginInit();
            panelcita.SuspendLayout();
            panelcita2.SuspendLayout();
            SuspendLayout();
            // 
            // Buscadortxt
            // 
            Buscadortxt.Location = new Point(303, 20);
            Buscadortxt.Name = "Buscadortxt";
            Buscadortxt.PlaceholderText = "Buscar pacientes";
            Buscadortxt.Size = new Size(332, 23);
            Buscadortxt.TabIndex = 8;
            Buscadortxt.TextChanged += Buscadortxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 9;
            label1.Text = "Citas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnsoporte);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(button16);
            panel3.Controls.Add(button17);
            panel3.Controls.Add(button18);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 524);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(163, 22);
            label2.TabIndex = 9;
            label2.Text = "System EDUSEX";
            // 
            // button11
            // 
            button11.Location = new Point(36, 430);
            button11.Name = "button11";
            button11.Size = new Size(102, 23);
            button11.TabIndex = 8;
            button11.Text = "Cerrar Sesion";
            button11.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.AutoScrollMargin = new Size(200, 1);
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(0, 337);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 7;
            // 
            // btnsoporte
            // 
            btnsoporte.BackColor = Color.Transparent;
            btnsoporte.Location = new Point(36, 384);
            btnsoporte.Name = "btnsoporte";
            btnsoporte.Size = new Size(105, 23);
            btnsoporte.TabIndex = 5;
            btnsoporte.Text = "Soporte IT";
            btnsoporte.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSkyBlue;
            button14.Location = new Point(36, 277);
            button14.Name = "button14";
            button14.Size = new Size(105, 23);
            button14.TabIndex = 4;
            button14.Text = "Guia Educativa";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.LightSkyBlue;
            button15.Location = new Point(36, 231);
            button15.Name = "button15";
            button15.Size = new Size(105, 23);
            button15.TabIndex = 3;
            button15.Text = "Hospital";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.SkyBlue;
            button16.Location = new Point(36, 182);
            button16.Name = "button16";
            button16.Size = new Size(105, 23);
            button16.TabIndex = 2;
            button16.Text = "Citas";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.LightSkyBlue;
            button17.Location = new Point(36, 131);
            button17.Name = "button17";
            button17.Size = new Size(105, 23);
            button17.TabIndex = 1;
            button17.Text = "Usuarios";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.LightSkyBlue;
            button18.ForeColor = SystemColors.ActiveCaptionText;
            button18.Location = new Point(36, 77);
            button18.Name = "button18";
            button18.Size = new Size(102, 23);
            button18.TabIndex = 1;
            button18.Text = "Inicio";
            button18.UseVisualStyleBackColor = false;
            // 
            // dgwCitas
            // 
            dgwCitas.BackgroundColor = SystemColors.ButtonHighlight;
            dgwCitas.BorderStyle = BorderStyle.Fixed3D;
            dgwCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitas.Location = new Point(220, 313);
            dgwCitas.Name = "dgwCitas";
            dgwCitas.Size = new Size(579, 199);
            dgwCitas.TabIndex = 13;
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(10, 126);
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
            label6.Location = new Point(153, 126);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 17;
            label6.Text = "Sexo";
            // 
            // panelcita
            // 
            panelcita.BackColor = SystemColors.ButtonFace;
            panelcita.BorderStyle = BorderStyle.Fixed3D;
            panelcita.Controls.Add(comboBox2);
            panelcita.Controls.Add(comboBox1);
            panelcita.Controls.Add(textBox2);
            panelcita.Controls.Add(textBox1);
            panelcita.Controls.Add(lblnombre);
            panelcita.Controls.Add(lbledad);
            panelcita.Controls.Add(label6);
            panelcita.Controls.Add(llbapellidos);
            panelcita.Location = new Point(220, 64);
            panelcita.Name = "panelcita";
            panelcita.Size = new Size(302, 177);
            panelcita.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(190, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(50, 23);
            comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(50, 23);
            comboBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 18;
            // 
            // panelcita2
            // 
            panelcita2.BackColor = SystemColors.ButtonFace;
            panelcita2.BorderStyle = BorderStyle.Fixed3D;
            panelcita2.Controls.Add(button1);
            panelcita2.Controls.Add(btnAgendacita);
            panelcita2.Controls.Add(panelestado);
            panelcita2.Controls.Add(label4);
            panelcita2.Controls.Add(panelmotivodecita);
            panelcita2.Controls.Add(dateTimePicker2);
            panelcita2.Controls.Add(dateTimePicker1);
            panelcita2.Controls.Add(comboBox3);
            panelcita2.Controls.Add(lblHospital);
            panelcita2.Controls.Add(lblmotivo);
            panelcita2.Controls.Add(lblhora);
            panelcita2.Controls.Add(llbfecha);
            panelcita2.Location = new Point(561, 64);
            panelcita2.Name = "panelcita2";
            panelcita2.Size = new Size(344, 190);
            panelcita2.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(207, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAgendacita
            // 
            btnAgendacita.BackColor = Color.PaleTurquoise;
            btnAgendacita.Location = new Point(67, 152);
            btnAgendacita.Name = "btnAgendacita";
            btnAgendacita.Size = new Size(75, 23);
            btnAgendacita.TabIndex = 26;
            btnAgendacita.Text = "Agendar Cita";
            btnAgendacita.UseVisualStyleBackColor = false;
            btnAgendacita.Click += button1_Click;
            // 
            // panelestado
            // 
            panelestado.FormattingEnabled = true;
            panelestado.Location = new Point(275, 108);
            panelestado.Name = "panelestado";
            panelestado.Size = new Size(40, 23);
            panelestado.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 114);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 24;
            label4.Text = "Estado";
            label4.Click += label4_Click;
            // 
            // panelmotivodecita
            // 
            panelmotivodecita.FormattingEnabled = true;
            panelmotivodecita.Location = new Point(165, 108);
            panelmotivodecita.Name = "panelmotivodecita";
            panelmotivodecita.Size = new Size(44, 23);
            panelmotivodecita.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(49, 108);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(48, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(67, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(67, 23);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(123, 23);
            comboBox3.TabIndex = 21;
            // 
            // lblHospital
            // 
            lblHospital.AutoSize = true;
            lblHospital.Location = new Point(10, 26);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new Size(51, 15);
            lblHospital.TabIndex = 15;
            lblHospital.Text = "Hospital";
            // 
            // lblmotivo
            // 
            lblmotivo.AutoSize = true;
            lblmotivo.Location = new Point(114, 114);
            lblmotivo.Name = "lblmotivo";
            lblmotivo.Size = new Size(45, 15);
            lblmotivo.TabIndex = 14;
            lblmotivo.Text = "Motivo";
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(10, 116);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(33, 15);
            lblhora.TabIndex = 17;
            lblhora.Text = "Hora";
            // 
            // llbfecha
            // 
            llbfecha.AutoSize = true;
            llbfecha.Location = new Point(10, 65);
            llbfecha.Name = "llbfecha";
            llbfecha.Size = new Size(38, 15);
            llbfecha.TabIndex = 16;
            llbfecha.Text = "Fecha";
            llbfecha.Click += label10_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 277);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 20;
            label3.Text = "Citas Agendadas";
            // 
            // btnEditarcita
            // 
            btnEditarcita.BackColor = Color.LightSeaGreen;
            btnEditarcita.ForeColor = SystemColors.ButtonFace;
            btnEditarcita.Location = new Point(830, 368);
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
            btnEliminarcita.Location = new Point(830, 430);
            btnEliminarcita.Name = "btnEliminarcita";
            btnEliminarcita.Size = new Size(90, 30);
            btnEliminarcita.TabIndex = 28;
            btnEliminarcita.Text = "Eliminar";
            btnEliminarcita.UseVisualStyleBackColor = false;
            // 
            // FrmHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 524);
            Controls.Add(btnEliminarcita);
            Controls.Add(btnEditarcita);
            Controls.Add(label3);
            Controls.Add(panelcita2);
            Controls.Add(panelcita);
            Controls.Add(dgwCitas);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(Buscadortxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospital";
            Text = "Citas";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCitas).EndInit();
            panelcita.ResumeLayout(false);
            panelcita.PerformLayout();
            panelcita2.ResumeLayout(false);
            panelcita2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox Buscadortxt;
        private Panel panel3;
        private Label label2;
        private Button button11;
        private Panel panel4;
        private Button btnsoporte;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private DataGridView dgwCitas;
        private Label lbledad;
        private Label lblnombre;
        private Label llbapellidos;
        private Label label6;
        private Panel panelcita;
        private Panel panelcita2;
        private Label lblHospital;
        private Label lblmotivo;
        private Label lblhora;
        private Label llbfecha;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox panelmotivodecita;
        private DateTimePicker dateTimePicker2;
        private ComboBox panelestado;
        private Button btnAgendacita;
        private Button button1;
        private Button btnEditarcita;
        private Button btnEliminarcita;
    }
}