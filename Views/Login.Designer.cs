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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            panelLogin = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            txtUsuario = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ImgEdusex = new PictureBox();
            linkCreateCuenta = new LinkLabel();
            btnInicioSesion = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            txtPassword = new TextBox();
            usuariosBindingSource = new BindingSource(components);
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgEdusex).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuariosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 54);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 1;
            label2.Text = "EDUSEX NICARAGUA";
            label2.Click += label2_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(ImgEdusex);
            panelLogin.Controls.Add(linkCreateCuenta);
            panelLogin.Controls.Add(btnInicioSesion);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(panel3);
            panelLogin.Location = new Point(263, -1);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(431, 652);
            panelLogin.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(43, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 36);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 89, 182);
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 2);
            panel2.TabIndex = 18;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(3, 17);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(325, 16);
            txtUsuario.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 335);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 19;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 243);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 16;
            label4.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 162);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 15;
            label3.Text = "Iniciar Sesion";
            // 
            // ImgEdusex
            // 
            ImgEdusex.Image = Properties.Resources.edusex_logo_redesign_4;
            ImgEdusex.Location = new Point(57, 25);
            ImgEdusex.Name = "ImgEdusex";
            ImgEdusex.Size = new Size(97, 72);
            ImgEdusex.SizeMode = PictureBoxSizeMode.Zoom;
            ImgEdusex.TabIndex = 14;
            ImgEdusex.TabStop = false;
            // 
            // linkCreateCuenta
            // 
            linkCreateCuenta.AutoSize = true;
            linkCreateCuenta.Location = new Point(110, 505);
            linkCreateCuenta.Name = "linkCreateCuenta";
            linkCreateCuenta.Size = new Size(210, 15);
            linkCreateCuenta.TabIndex = 7;
            linkCreateCuenta.TabStop = true;
            linkCreateCuenta.Text = "No tienes usuario? Crea tu cuenta aqui";
            linkCreateCuenta.LinkClicked += linkCreateCuenta_LinkClicked;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.DarkViolet;
            btnInicioSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicioSesion.ForeColor = SystemColors.ButtonFace;
            btnInicioSesion.Location = new Point(43, 436);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(330, 35);
            btnInicioSesion.TabIndex = 6;
            btnInicioSesion.Text = "Entrar";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(44, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 36);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(159, 89, 182);
            panel4.Location = new Point(0, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 2);
            panel4.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(1, 17);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(325, 16);
            txtPassword.TabIndex = 20;
            // 
            // usuariosBindingSource
            // 
            usuariosBindingSource.DataSource = typeof(Models.Usuarios);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(934, 611);
            Controls.Add(panelLogin);
            MaximumSize = new Size(950, 650);
            MinimumSize = new Size(800, 650);
            Name = "Login";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgEdusex).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usuariosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label4;
        private Panel panelLogin;
        private Button btnInicioSesion;
        private LinkLabel linkCreateCuenta;
        private BindingSource usuariosBindingSource;
        private PictureBox ImgEdusex;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}