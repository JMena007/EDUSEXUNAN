using EDUSEX.Models;
using EDUSEX.Controllers;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dvgUsuarios = new DataGridView();
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgUsuarios
            // 
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dvgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgUsuarios.BackgroundColor = SystemColors.Control;
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.GridColor = SystemColors.InactiveBorder;
            dvgUsuarios.Location = new Point(250, 310);
            dvgUsuarios.Name = "dvgUsuarios";
            dvgUsuarios.Size = new Size(546, 203);
            dvgUsuarios.TabIndex = 0;
            dvgUsuarios.CellContentClick += dvgUsuarios_CellContentClick;
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
            label3.Location = new Point(8, 16);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 109);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 109);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 154);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Edad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 21);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 12;
            label8.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(65, 8);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(239, 23);
            txtnombre.TabIndex = 13;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(65, 101);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(239, 23);
            txtCedula.TabIndex = 15;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(65, 50);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(239, 23);
            txtapellido.TabIndex = 16;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(264, 164);
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
            btnEditar.Location = new Point(811, 356);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(811, 424);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(410, 164);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 58);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 23;
            label9.Text = "Correo";
            label9.Click += label9_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(406, 55);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(239, 23);
            txtCorreo.TabIndex = 24;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(406, 13);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 23);
            txtTelefono.TabIndex = 25;
            txtTelefono.MaskInputRejected += txtTelefono_MaskInputRejected;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(49, 152);
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
            boxsexo.Location = new Point(410, 101);
            boxsexo.Name = "boxsexo";
            boxsexo.Size = new Size(121, 23);
            boxsexo.TabIndex = 27;
            boxsexo.SelectedIndexChanged += boxsexo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(boxsexo);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(numEdad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtapellido);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(250, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 222);
            panel1.TabIndex = 28;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 541);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dvgUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "Registro de Usuarios";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dvgUsuarios;
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


        //Metodo agregado al evento btnlimpiar

       
        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

       

        

       
        private MaskedTextBox txtTelefono;
        private NumericUpDown numEdad;
        private ComboBox boxsexo;
        private Panel panel1;
    }
}