namespace EDUSEX
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel3 = new Panel();
            btnCloseSesion = new Button();
            btnSoporte = new Button();
            btnGuiaEdu = new Button();
            button3 = new Button();
            btnCitas = new Button();
            btnHospitales = new Button();
            label3 = new Label();
            panel4 = new Panel();
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 25);
            label1.Name = "label1";
            label1.Size = new Size(242, 22);
            label1.TabIndex = 2;
            label1.Text = "Bienvenidos a EDUSEX Nicaragua";
            label1.Click += label1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(btnCloseSesion);
            panel3.Controls.Add(btnSoporte);
            panel3.Controls.Add(btnGuiaEdu);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnCitas);
            panel3.Controls.Add(btnHospitales);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnInicio);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 518);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // btnCloseSesion
            // 
            btnCloseSesion.BackColor = Color.FromArgb(0, 0, 97);
            btnCloseSesion.FlatAppearance.BorderColor = Color.Navy;
            btnCloseSesion.FlatStyle = FlatStyle.Flat;
            btnCloseSesion.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseSesion.ForeColor = SystemColors.Control;
            btnCloseSesion.Location = new Point(0, 446);
            btnCloseSesion.Name = "btnCloseSesion";
            btnCloseSesion.Size = new Size(194, 28);
            btnCloseSesion.TabIndex = 15;
            btnCloseSesion.Text = "Cerrar Sesion";
            btnCloseSesion.UseVisualStyleBackColor = false;
            btnCloseSesion.Click += btnCloseSesion_Click;
            // 
            // btnSoporte
            // 
            btnSoporte.BackColor = Color.FromArgb(0, 0, 97);
            btnSoporte.FlatAppearance.BorderColor = Color.Navy;
            btnSoporte.FlatStyle = FlatStyle.Flat;
            btnSoporte.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoporte.ForeColor = SystemColors.Control;
            btnSoporte.Location = new Point(3, 402);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Size = new Size(194, 28);
            btnSoporte.TabIndex = 14;
            btnSoporte.Text = "Soporte IT";
            btnSoporte.UseVisualStyleBackColor = false;
            btnSoporte.Click += btnSoporte_Click;
            // 
            // btnGuiaEdu
            // 
            btnGuiaEdu.BackColor = Color.FromArgb(0, 0, 97);
            btnGuiaEdu.FlatAppearance.BorderColor = Color.Navy;
            btnGuiaEdu.FlatStyle = FlatStyle.Flat;
            btnGuiaEdu.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiaEdu.ForeColor = SystemColors.Control;
            btnGuiaEdu.Location = new Point(3, 288);
            btnGuiaEdu.Name = "btnGuiaEdu";
            btnGuiaEdu.Size = new Size(194, 28);
            btnGuiaEdu.TabIndex = 13;
            btnGuiaEdu.Text = "Guia Educativa";
            btnGuiaEdu.UseVisualStyleBackColor = false;
            btnGuiaEdu.Click += btnGuiaEdu_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 97);
            button3.FlatAppearance.BorderColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(3, 132);
            button3.Name = "button3";
            button3.Size = new Size(194, 28);
            button3.TabIndex = 12;
            button3.Text = "Usuarios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnUsuario_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(0, 0, 97);
            btnCitas.FlatAppearance.BorderColor = Color.Navy;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCitas.ForeColor = SystemColors.Control;
            btnCitas.Location = new Point(3, 183);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(194, 28);
            btnCitas.TabIndex = 11;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += button2_Click_1;
            // 
            // btnHospitales
            // 
            btnHospitales.BackColor = Color.FromArgb(0, 0, 97);
            btnHospitales.FlatAppearance.BorderColor = Color.Navy;
            btnHospitales.FlatStyle = FlatStyle.Flat;
            btnHospitales.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHospitales.ForeColor = SystemColors.Control;
            btnHospitales.Location = new Point(3, 235);
            btnHospitales.Name = "btnHospitales";
            btnHospitales.Size = new Size(194, 28);
            btnHospitales.TabIndex = 10;
            btnHospitales.Text = "Hospitales";
            btnHospitales.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(21, 24);
            label3.Name = "label3";
            label3.Size = new Size(163, 22);
            label3.TabIndex = 9;
            label3.Text = "System EDUSEX";
            // 
            // panel4
            // 
            panel4.AutoScrollMargin = new Size(200, 1);
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Location = new Point(3, 369);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 7;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(0, 0, 97);
            btnInicio.FlatAppearance.BorderColor = Color.Navy;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Location = new Point(3, 79);
            btnInicio.Name = "btnInicio";
            btnInicio.RightToLeft = RightToLeft.Yes;
            btnInicio.Size = new Size(194, 28);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(368, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 351);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(999, 518);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel3;
        private Button btnGuiaEdu;
        private Button button3;
        private Button btnCitas;
        private Button btnHospitales;
        private Label label3;
        private Panel panel4;
        private Button btnInicio;
        private Button btnSoporte;
        private Button btnCloseSesion;
        private PictureBox pictureBox1;
    }
}

