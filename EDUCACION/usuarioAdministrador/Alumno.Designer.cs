namespace EDUCACION
{
    partial class Alumno
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.Botones = new System.Windows.Forms.GroupBox();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdProfesor = new System.Windows.Forms.RadioButton();
            this.rdEstudiante = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(97, 323);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(136, 22);
            this.txtTipo.TabIndex = 48;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.rdAdmin);
            this.Botones.Controls.Add(this.rdProfesor);
            this.Botones.Controls.Add(this.rdEstudiante);
            this.Botones.Location = new System.Drawing.Point(18, 270);
            this.Botones.Margin = new System.Windows.Forms.Padding(4);
            this.Botones.Name = "Botones";
            this.Botones.Padding = new System.Windows.Forms.Padding(4);
            this.Botones.Size = new System.Drawing.Size(312, 52);
            this.Botones.TabIndex = 47;
            this.Botones.TabStop = false;
            this.Botones.Text = "Tipo";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Location = new System.Drawing.Point(195, 25);
            this.rdAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(111, 20);
            this.rdAdmin.TabIndex = 19;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrador";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdProfesor
            // 
            this.rdProfesor.AutoSize = true;
            this.rdProfesor.Location = new System.Drawing.Point(101, 25);
            this.rdProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.rdProfesor.Name = "rdProfesor";
            this.rdProfesor.Size = new System.Drawing.Size(79, 20);
            this.rdProfesor.TabIndex = 18;
            this.rdProfesor.TabStop = true;
            this.rdProfesor.Text = "Profesor";
            this.rdProfesor.UseVisualStyleBackColor = true;
            // 
            // rdEstudiante
            // 
            this.rdEstudiante.AutoSize = true;
            this.rdEstudiante.Location = new System.Drawing.Point(8, 25);
            this.rdEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.rdEstudiante.Name = "rdEstudiante";
            this.rdEstudiante.Size = new System.Drawing.Size(91, 20);
            this.rdEstudiante.TabIndex = 17;
            this.rdEstudiante.TabStop = true;
            this.rdEstudiante.Text = "Estudiante";
            this.rdEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(158, 538);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 538);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(286, 538);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(414, 538);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(380, 105);
            this.dtgUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.RowHeadersWidth = 51;
            this.dtgUsuario.Size = new System.Drawing.Size(985, 343);
            this.dtgUsuario.TabIndex = 42;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(26, 474);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(205, 22);
            this.txtCorreo.TabIndex = 41;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(26, 426);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(132, 22);
            this.txtCelular.TabIndex = 40;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(29, 378);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 22);
            this.txtDireccion.TabIndex = 39;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(29, 238);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(300, 22);
            this.txtMaterno.TabIndex = 38;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(29, 190);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(300, 22);
            this.txtPaterno.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(29, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 36;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(33, 94);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(132, 22);
            this.lblCodigo.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "CORREO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "CELULAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "APELLIDO MATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "CARNET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "INGRESA LOS DATOS CORRESPONDIENTES";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1394, 641);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.Botones.ResumeLayout(false);
            this.Botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox Botones;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdProfesor;
        private System.Windows.Forms.RadioButton rdEstudiante;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox lblCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}