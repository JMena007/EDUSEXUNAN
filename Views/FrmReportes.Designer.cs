namespace EDUSEX.Views
{
    partial class FrmReportes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dgwHospitales = new DataGridView();
            btnReport = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbHospitales = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgwHospitales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(392, 24);
            label1.Name = "label1";
            label1.Size = new Size(266, 27);
            label1.TabIndex = 12;
            label1.Text = "Reportes por Hospitales";
            // 
            // dgwHospitales
            // 
            dgwHospitales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwHospitales.BackgroundColor = SystemColors.ButtonFace;
            dgwHospitales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwHospitales.Location = new Point(241, 230);
            dgwHospitales.Name = "dgwHospitales";
            dgwHospitales.Size = new Size(559, 359);
            dgwHospitales.TabIndex = 13;
            dgwHospitales.CellContentClick += dgwHospitales_CellContentClick;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReport.BackColor = Color.Transparent;
            btnReport.BorderRadius = 10;
            btnReport.Cursor = Cursors.Hand;
            btnReport.CustomizableEdges = customizableEdges1;
            btnReport.DisabledState.BorderColor = Color.DarkGray;
            btnReport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReport.FillColor = Color.Fuchsia;
            btnReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(806, 296);
            btnReport.Name = "btnReport";
            btnReport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReport.Size = new Size(119, 42);
            btnReport.TabIndex = 14;
            btnReport.Text = "Generar Reporte";
            btnReport.Click += btnReport_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(292, 128);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(195, 27);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "Selecciona el Hospital";
            // 
            // cmbHospitales
            // 
            cmbHospitales.BackColor = Color.Transparent;
            cmbHospitales.CustomizableEdges = customizableEdges3;
            cmbHospitales.DrawMode = DrawMode.OwnerDrawFixed;
            cmbHospitales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHospitales.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbHospitales.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbHospitales.Font = new Font("Segoe UI", 10F);
            cmbHospitales.ForeColor = Color.FromArgb(68, 88, 112);
            cmbHospitales.ItemHeight = 30;
            cmbHospitales.Location = new Point(512, 119);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbHospitales.Size = new Size(227, 36);
            cmbHospitales.TabIndex = 16;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(241, 197);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(148, 27);
            guna2HtmlLabel2.TabIndex = 17;
            guna2HtmlLabel2.Text = "Citas registradas";
            // 
            // FrmHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(950, 650);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(cmbHospitales);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnReport);
            Controls.Add(dgwHospitales);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospitales";
            Text = "Hospitales";
            Load += FrmHospitales_Load;
            ((System.ComponentModel.ISupportInitialize)dgwHospitales).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dgwHospitales;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHospitales;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}