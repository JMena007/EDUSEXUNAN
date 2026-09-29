namespace EDUSEX.Views
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            panelLogin = new Panel();
            linkCreateCuenta = new LinkLabel();
            btnInicioSesion = new Button();
            inputContraseña = new TextBox();
            lnputUsertxt = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(346, 56);
            label1.Name = "label1";
            label1.Size = new Size(343, 22);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a EDUSEX NICARAGUA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 34);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesion";
            label2.Click += label2_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(linkCreateCuenta);
            panelLogin.Controls.Add(btnInicioSesion);
            panelLogin.Controls.Add(inputContraseña);
            panelLogin.Controls.Add(lnputUsertxt);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new Point(265, 110);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(495, 324);
            panelLogin.TabIndex = 4;
            // 
            // linkCreateCuenta
            // 
            linkCreateCuenta.AutoSize = true;
            linkCreateCuenta.Location = new Point(133, 252);
            linkCreateCuenta.Name = "linkCreateCuenta";
            linkCreateCuenta.Size = new Size(210, 15);
            linkCreateCuenta.TabIndex = 7;
            linkCreateCuenta.TabStop = true;
            linkCreateCuenta.Text = "No tienes usuario? Crea tu cuenta aqui";
            linkCreateCuenta.LinkClicked += linkCreateCuenta_LinkClicked;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.RoyalBlue;
            btnInicioSesion.ForeColor = SystemColors.ButtonFace;
            btnInicioSesion.Location = new Point(180, 201);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(110, 35);
            btnInicioSesion.TabIndex = 6;
            btnInicioSesion.Text = "Entrar";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // inputContraseña
            // 
            inputContraseña.BorderStyle = BorderStyle.FixedSingle;
            inputContraseña.Location = new Point(106, 152);
            inputContraseña.Name = "inputContraseña";
            inputContraseña.PasswordChar = '.';
            inputContraseña.PlaceholderText = "Contraseña";
            inputContraseña.Size = new Size(257, 23);
            inputContraseña.TabIndex = 3;
            inputContraseña.TextChanged += inputContraseña_TextChanged;
            inputContraseña.KeyDown += CampoTexto_KeyDown;
            // 
            // lnputUsertxt
            // 
            lnputUsertxt.BorderStyle = BorderStyle.FixedSingle;
            lnputUsertxt.Location = new Point(106, 93);
            lnputUsertxt.Name = "lnputUsertxt";
            lnputUsertxt.PlaceholderText = "Correo@EDUSEX";
            lnputUsertxt.Size = new Size(257, 23);
            lnputUsertxt.TabIndex = 2;
            lnputUsertxt.TextChanged += lnputUsertxt_TextChanged;
            lnputUsertxt.KeyDown += CampoTexto_KeyDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1033, 521);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            RightToLeft = RightToLeft.No;
            Text = "Login";
            Load += Login_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelLogin;
        private TextBox inputContraseña;
        private TextBox lnputUsertxt;
        private Button btnInicioSesion;
        private LinkLabel linkCreateCuenta;
    }
}