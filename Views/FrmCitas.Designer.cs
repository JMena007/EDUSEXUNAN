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
            panel3.SuspendLayout();
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
            panel3.Size = new Size(200, 471);
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
            // FrmHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(Buscadortxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospital";
            Text = "Citas";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}