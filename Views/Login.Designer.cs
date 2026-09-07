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
            label3 = new Label();
            label4 = new Label();
            panelLogin = new Panel();
            btnInicioSesion = new Button();
            linkInvitado = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(323, 62);
            label1.Name = "label1";
            label1.Size = new Size(343, 22);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a EDUSEX NICARAGUA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 12);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesion";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(164, 117);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(175, 54);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            label4.Click += label4_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(btnInicioSesion);
            panelLogin.Controls.Add(linkInvitado);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Controls.Add(textBox1);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label4);
            panelLogin.Location = new Point(297, 124);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(396, 272);
            panelLogin.TabIndex = 4;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.RoyalBlue;
            btnInicioSesion.ForeColor = SystemColors.ButtonFace;
            btnInicioSesion.Location = new Point(155, 179);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(93, 30);
            btnInicioSesion.TabIndex = 6;
            btnInicioSesion.Text = "Entrar";
            btnInicioSesion.UseVisualStyleBackColor = false;
            // 
            // linkInvitado
            // 
            linkInvitado.AutoSize = true;
            linkInvitado.DisabledLinkColor = Color.White;
            linkInvitado.Location = new Point(136, 239);
            linkInvitado.Name = "linkInvitado";
            linkInvitado.Size = new Size(130, 15);
            linkInvitado.TabIndex = 5;
            linkInvitado.TabStop = true;
            linkInvitado.Text = "Acceder como Invitado";
            linkInvitado.LinkClicked += linkInvitado_LinkClicked;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(106, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(106, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(990, 520);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
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
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel linkInvitado;
        private Button btnInicioSesion;
    }
}
