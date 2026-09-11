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
            linkInvitado = new LinkLabel();
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
            label1.Location = new Point(337, 51);
            label1.Name = "label1";
            label1.Size = new Size(343, 22);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a EDUSEX NICARAGUA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
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
            panelLogin.Controls.Add(linkInvitado);
            panelLogin.Controls.Add(inputContraseña);
            panelLogin.Controls.Add(lnputUsertxt);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new Point(318, 135);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(402, 272);
            panelLogin.TabIndex = 4;
            // 
            // linkCreateCuenta
            // 
            linkCreateCuenta.AutoSize = true;
            linkCreateCuenta.Location = new Point(95, 208);
            linkCreateCuenta.Name = "linkCreateCuenta";
            linkCreateCuenta.Size = new Size(210, 15);
            linkCreateCuenta.TabIndex = 7;
            linkCreateCuenta.TabStop = true;
            linkCreateCuenta.Text = "No tienes usuario? Crea tu cuenta aqui";
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.RoyalBlue;
            btnInicioSesion.ForeColor = SystemColors.ButtonFace;
            btnInicioSesion.Location = new Point(142, 155);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(120, 35);
            btnInicioSesion.TabIndex = 6;
            btnInicioSesion.Text = "Entrar";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // linkInvitado
            // 
            linkInvitado.AutoSize = true;
            linkInvitado.DisabledLinkColor = Color.White;
            linkInvitado.Location = new Point(132, 238);
            linkInvitado.Name = "linkInvitado";
            linkInvitado.Size = new Size(130, 15);
            linkInvitado.TabIndex = 5;
            linkInvitado.TabStop = true;
            linkInvitado.Text = "Acceder como Invitado";
            linkInvitado.LinkClicked += linkInvitado_LinkClicked;
            // 
            // inputContraseña
            // 
            inputContraseña.BorderStyle = BorderStyle.FixedSingle;
            inputContraseña.Location = new Point(87, 115);
            inputContraseña.Name = "inputContraseña";
            inputContraseña.PlaceholderText = "Contraseña";
            inputContraseña.Size = new Size(221, 23);
            inputContraseña.TabIndex = 3;
            // 
            // lnputUsertxt
            // 
            lnputUsertxt.BorderStyle = BorderStyle.FixedSingle;
            lnputUsertxt.Location = new Point(87, 71);
            lnputUsertxt.Name = "lnputUsertxt";
            lnputUsertxt.PlaceholderText = "Correo@EDUSEX";
            lnputUsertxt.Size = new Size(221, 23);
            lnputUsertxt.TabIndex = 2;
            lnputUsertxt.TextChanged += lnputUsertxt_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1000, 521);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
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
        private LinkLabel linkInvitado;
        private Button btnInicioSesion;
        private LinkLabel linkCreateCuenta;
    }
}
