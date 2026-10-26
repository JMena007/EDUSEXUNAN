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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            BtnActualizar = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgUsuarios
            // 
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dvgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgUsuarios.BackgroundColor = SystemColors.Control;
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.GridColor = SystemColors.InactiveBorder;
            dvgUsuarios.Location = new Point(229, 316);
            dvgUsuarios.Name = "dvgUsuarios";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgUsuarios.Size = new Size(598, 213);
            dvgUsuarios.TabIndex = 0;
            dvgUsuarios.CellContentClick += dvgUsuarios_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 6;
            label1.Text = "Gestion de Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 16);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(406, 16);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(406, 78);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(406, 140);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(543, 140);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Edad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 78);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 12;
            label8.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(40, 34);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(247, 23);
            txtnombre.TabIndex = 13;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(406, 96);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(247, 23);
            txtCedula.TabIndex = 15;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(410, 34);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(247, 23);
            txtapellido.TabIndex = 16;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(159, 89, 182);
            btnGuardar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(139, 207);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 38);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.DarkOrchid;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(843, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 38);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(843, 425);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 37);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(300, 207);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 38);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 140);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 23;
            label9.Text = "Correo";
            label9.Click += label9_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(41, 157);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(247, 23);
            txtCorreo.TabIndex = 24;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(40, 96);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 25;
            txtTelefono.KeyPress += txtTelefono_keyPress;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(543, 158);
            numEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(110, 23);
            numEdad.TabIndex = 26;
            numEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // boxsexo
            // 
            boxsexo.DropDownStyle = ComboBoxStyle.DropDownList;
            boxsexo.FormattingEnabled = true;
            boxsexo.Items.AddRange(new object[] { "Seleccionar", "Masculino", "femenino", "No Binarie", "Otros" });
            boxsexo.Location = new Point(403, 158);
            boxsexo.Name = "boxsexo";
            boxsexo.Size = new Size(103, 23);
            boxsexo.TabIndex = 27;
            boxsexo.SelectedIndexChanged += boxsexo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnActualizar);
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
            panel1.Location = new Point(229, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 262);
            panel1.TabIndex = 28;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(159, 89, 182);
            panel8.Location = new Point(547, 179);
            panel8.Name = "panel8";
            panel8.Size = new Size(104, 2);
            panel8.TabIndex = 34;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(159, 89, 182);
            panel7.Location = new Point(403, 177);
            panel7.Name = "panel7";
            panel7.Size = new Size(102, 2);
            panel7.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(159, 89, 182);
            panel6.Location = new Point(410, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 2);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(159, 89, 182);
            panel5.Location = new Point(407, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 2);
            panel5.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(159, 89, 182);
            panel4.Location = new Point(41, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 2);
            panel4.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(159, 89, 182);
            panel3.Location = new Point(41, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 2);
            panel3.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 89, 182);
            panel2.Location = new Point(43, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 2);
            panel2.TabIndex = 29;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = SystemColors.MenuHighlight;
            BtnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(476, 207);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(100, 38);
            BtnActualizar.TabIndex = 28;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Visible = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(0, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 0;
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
            if (e.RowIndex < 0)
                return;

            dvgUsuarios.Rows[e.RowIndex].Selected = true;
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

            numEdad.Value = numEdad.Minimum;
            boxsexo.SelectedIndex = 0;

            idUsuarioEditando = null;

            BtnActualizar.Visible = false;
            btnGuardar.Visible = true;
            btnLimpiar.Text = "Limpiar";
        }

       

        

       
        private MaskedTextBox txtTelefono;
        private NumericUpDown numEdad;
        private ComboBox boxsexo;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Button BtnActualizar;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
    }
}