namespace EDUSEX.Views
{
    partial class FrmHospitales
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
            panel3 = new Panel();
            label3 = new Label();
            button11 = new Button();
            panel4 = new Panel();
            btnsoporte = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label3);
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
            panel3.Size = new Size(200, 450);
            panel3.TabIndex = 11;
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
            // FrmHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospitales";
            Text = "Hospitales";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Button button11;
        private Panel panel4;
        private Button btnsoporte;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}