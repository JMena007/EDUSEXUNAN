namespace EDUSEX.Views
{
    public partial class FrmUsuario : Form
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            button10 = new Button();
            panelSeparador = new Panel();
            btnsoporte = new Button();
            button12 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnUsuarios = new Button();
            button1BtnInicio = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtnombre = new TextBox();
            txtCedula = new TextBox();
            txtapellido = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label9 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new MaskedTextBox();
            numEdad = new NumericUpDown();
            boxsexo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(250, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(534, 203);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(panelSeparador);
            panel2.Controls.Add(btnsoporte);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(button1BtnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 541);
            panel2.TabIndex = 5;
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
            // button10
            // 
            button10.Location = new Point(36, 430);
            button10.Name = "button10";
            button10.Size = new Size(102, 23);
            button10.TabIndex = 8;
            button10.Text = "Cerrar Sesion";
            button10.UseVisualStyleBackColor = true;
            // 
            // panelSeparador
            // 
            panelSeparador.AutoScrollMargin = new Size(200, 1);
            panelSeparador.BackColor = SystemColors.ControlLightLight;
            panelSeparador.Location = new Point(0, 337);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(200, 1);
            panelSeparador.TabIndex = 7;
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
            btnsoporte.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSkyBlue;
            button12.Location = new Point(36, 277);
            button12.Name = "button12";
            button12.Size = new Size(105, 23);
            button12.TabIndex = 4;
            button12.Text = "Guia Educativa";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSkyBlue;
            button8.Location = new Point(36, 231);
            button8.Name = "button8";
            button8.Size = new Size(105, 23);
            button8.TabIndex = 3;
            button8.Text = "Hospital";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.SkyBlue;
            button9.Location = new Point(36, 182);
            button9.Name = "button9";
            button9.Size = new Size(105, 23);
            button9.TabIndex = 2;
            button9.Text = "Citas";
            button9.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.LightSkyBlue;
            btnUsuarios.Location = new Point(36, 131);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(105, 23);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // button1BtnInicio
            // 
            button1BtnInicio.BackColor = Color.LightSkyBlue;
            button1BtnInicio.ForeColor = SystemColors.ActiveCaptionText;
            button1BtnInicio.Location = new Point(36, 77);
            button1BtnInicio.Name = "button1BtnInicio";
            button1BtnInicio.Size = new Size(102, 23);
            button1BtnInicio.TabIndex = 1;
            button1BtnInicio.Text = "Inicio";
            button1BtnInicio.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 6;
            label1.Text = "Gestion de Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 64);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 106);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 147);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 159);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 186);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Edad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(604, 59);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 12;
            label8.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(303, 56);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(239, 23);
            txtnombre.TabIndex = 13;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(303, 139);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(239, 23);
            txtCedula.TabIndex = 15;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(303, 98);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(239, 23);
            txtapellido.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(404, 231);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 255, 255);
            btnEditar.ForeColor = Color.FromArgb(64, 64, 64);
            btnEditar.Location = new Point(814, 337);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(814, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(587, 231);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(604, 106);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 23;
            label9.Text = "Correo";
            label9.Click += label9_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(663, 98);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(239, 23);
            txtCorreo.TabIndex = 24;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(663, 51);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 23);
            txtTelefono.TabIndex = 25;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(303, 182);
            numEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(120, 23);
            numEdad.TabIndex = 26;
            numEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // boxsexo
            // 
            boxsexo.DropDownStyle = ComboBoxStyle.DropDownList;
            boxsexo.FormattingEnabled = true;
            boxsexo.Items.AddRange(new object[] { "Seleccionar", "Masculino", "femenino", "No Binarie", "Otros" });
            boxsexo.Location = new Point(663, 151);
            boxsexo.Name = "boxsexo";
            boxsexo.Size = new Size(121, 23);
            boxsexo.TabIndex = 27;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 541);
            Controls.Add(boxsexo);
            Controls.Add(numEdad);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtapellido);
            Controls.Add(txtCedula);
            Controls.Add(txtnombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private Button button10;
        private Panel panelSeparador;
        private Button btnsoporte;
        private Button button12;
        private Button button8;
        private Button button9;
        private Button btnUsuarios;
        private Button button1BtnInicio;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtnombre;
        private TextBox txtCedula;
        private TextBox txtapellido;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label9;
        private TextBox txtCorreo;

        

        private void button12_Click(object sender, EventArgs e)
        {
            // TODO: implementar la acción para button12 (Guia Educativa)
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // TODO: implementar la acción para btnUsuarios
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: implementar la acción para btnGuardar
        }

        private MaskedTextBox txtTelefono;
        private NumericUpDown numEdad;
        private ComboBox boxsexo;
    }
}