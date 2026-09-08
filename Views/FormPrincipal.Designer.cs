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
            btnReportes = new Button();
            button3 = new Button();
            btnCitas = new Button();
            btnHospitales = new Button();
            label3 = new Label();
            button11 = new Button();
            panel4 = new Panel();
            btnsoporte = new Button();
            btnInicio = new Button();
            panel3.SuspendLayout();
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
            panel3.Controls.Add(btnReportes);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnCitas);
            panel3.Controls.Add(btnHospitales);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnsoporte);
            panel3.Controls.Add(btnInicio);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 518);
            panel3.TabIndex = 12;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(0, 0, 97);
            btnReportes.FlatAppearance.BorderColor = Color.Navy;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = SystemColors.Control;
            btnReportes.Location = new Point(3, 288);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(194, 28);
            btnReportes.TabIndex = 13;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
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
            // button11
            // 
            button11.Location = new Point(39, 460);
            button11.Name = "button11";
            button11.Size = new Size(102, 23);
            button11.TabIndex = 8;
            button11.Text = "Cerrar Sesion";
            button11.UseVisualStyleBackColor = true;
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
            // btnsoporte
            // 
            btnsoporte.BackColor = Color.Transparent;
            btnsoporte.Location = new Point(39, 410);
            btnsoporte.Name = "btnsoporte";
            btnsoporte.Size = new Size(105, 23);
            btnsoporte.TabIndex = 5;
            btnsoporte.Text = "Soporte IT";
            btnsoporte.UseVisualStyleBackColor = false;
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
            btnInicio.Size = new Size(194, 28);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(999, 518);
            Controls.Add(panel3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel3;
        private Button btnReportes;
        private Button button3;
        private Button btnCitas;
        private Button btnHospitales;
        private Label label3;
        private Button button11;
        private Panel panel4;
        private Button btnsoporte;
        private Button btnInicio;
    }
}

