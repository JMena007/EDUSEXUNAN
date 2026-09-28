namespace EDUSEX.Views
{
    partial class CreateUsernew
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
            Label lblCedula;
            lblcuenta = new Label();
            panel1 = new Panel();
            nmEdad = new NumericUpDown();
            LblEdad = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblcorreo = new Label();
            lblTelefono = new Label();
            cmbSexo = new ComboBox();
            lblSexo = new Label();
            txtCedula = new TextBox();
            txtApellido = new TextBox();
            txtConfirmContraseña = new TextBox();
            txtContraseña = new TextBox();
            txtNombres = new TextBox();
            label4 = new Label();
            lblapellido = new Label();
            lblpassword = new Label();
            lblnombreU = new Label();
            btnCancelar = new Button();
            btnCreateUser = new Button();
            rolesBindingSource = new BindingSource(components);
            lblCedula = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(33, 155);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 18;
            lblCedula.Text = "Cedula";
            // 
            // lblcuenta
            // 
            lblcuenta.AutoSize = true;
            lblcuenta.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcuenta.Location = new Point(383, 42);
            lblcuenta.Name = "lblcuenta";
            lblcuenta.Size = new Size(171, 18);
            lblcuenta.TabIndex = 0;
            lblcuenta.Text = "Crea una Cuenta Ahora";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nmEdad);
            panel1.Controls.Add(LblEdad);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(lblcorreo);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(cmbSexo);
            panel1.Controls.Add(lblSexo);
            panel1.Controls.Add(lblCedula);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtConfirmContraseña);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblapellido);
            panel1.Controls.Add(lblpassword);
            panel1.Controls.Add(lblnombreU);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCreateUser);
            panel1.Location = new Point(57, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 342);
            panel1.TabIndex = 4;
            // 
            // nmEdad
            // 
            nmEdad.Location = new Point(252, 212);
            nmEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            nmEdad.Name = "nmEdad";
            nmEdad.Size = new Size(120, 23);
            nmEdad.TabIndex = 27;
            nmEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // LblEdad
            // 
            LblEdad.AutoSize = true;
            LblEdad.Location = new Point(213, 219);
            LblEdad.Name = "LblEdad";
            LblEdad.Size = new Size(33, 15);
            LblEdad.TabIndex = 25;
            LblEdad.Text = "Edad";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(550, 22);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 23);
            txtTelefono.TabIndex = 24;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(550, 88);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 23);
            txtCorreo.TabIndex = 23;
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new Point(474, 96);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(43, 15);
            lblcorreo.TabIndex = 22;
            lblcorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(474, 30);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Telefono";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            cmbSexo.Location = new Point(89, 211);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(80, 23);
            cmbSexo.TabIndex = 20;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(33, 219);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 19;
            lblSexo.Text = "Sexo";
            lblSexo.Click += lblSexo_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(113, 152);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(254, 23);
            txtCedula.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(254, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtConfirmContraseña
            // 
            txtConfirmContraseña.Location = new Point(550, 219);
            txtConfirmContraseña.Name = "txtConfirmContraseña";
            txtConfirmContraseña.Size = new Size(254, 23);
            txtConfirmContraseña.TabIndex = 13;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(550, 155);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(254, 23);
            txtContraseña.TabIndex = 12;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(113, 22);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(254, 23);
            txtNombres.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 227);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 10;
            label4.Text = "Confirmar Contraseña";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(33, 88);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(51, 15);
            lblapellido.TabIndex = 9;
            lblapellido.Text = "Apellido";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(460, 158);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(67, 15);
            lblpassword.TabIndex = 8;
            lblpassword.Text = "Contraseña";
            // 
            // lblnombreU
            // 
            lblnombreU.AutoSize = true;
            lblnombreU.Location = new Point(33, 25);
            lblnombreU.Name = "lblnombreU";
            lblnombreU.Size = new Size(51, 15);
            lblnombreU.TabIndex = 7;
            lblnombreU.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(449, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.DodgerBlue;
            btnCreateUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = SystemColors.ControlLight;
            btnCreateUser.Location = new Point(270, 281);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(109, 40);
            btnCreateUser.TabIndex = 5;
            btnCreateUser.Text = "Crear Cuenta";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // CreateUsernew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 450);
            Controls.Add(panel1);
            Controls.Add(lblcuenta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CreateUsernew";
            Text = "CreateUsernew";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)rolesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcuenta;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnCreateUser;
        private Label label4;
        private Label lblapellido;
        private Label lblpassword;
        private Label lblnombreU;
        private TextBox txtConfirmContraseña;
        private TextBox txtContraseña;
        private TextBox txtNombres;
        private BindingSource rolesBindingSource;
        private TextBox txtApellido;
        private ComboBox cmbSexo;
        private Label lblSexo;
        private TextBox txtCedula;
        private Label lblcorreo;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label LblEdad;
        private NumericUpDown nmEdad;
    }
}