namespace EDUCACION.usuarioAdministrador
{
    partial class Registro
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codAsignatura = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.ciAlumno = new System.Windows.Forms.TextBox();
            this.codCurso = new System.Windows.Forms.TextBox();
            this.gestion = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.dtgRegistro = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 16);
            this.label.TabIndex = 0;
            this.label.Text = "CODIGO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CI ALUMNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO CURSO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "GESTION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTAL:";
            // 
            // codAsignatura
            // 
            this.codAsignatura.Location = new System.Drawing.Point(201, 39);
            this.codAsignatura.Name = "codAsignatura";
            this.codAsignatura.Size = new System.Drawing.Size(262, 22);
            this.codAsignatura.TabIndex = 6;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(201, 291);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(262, 22);
            this.fecha.TabIndex = 7;
            // 
            // ciAlumno
            // 
            this.ciAlumno.Location = new System.Drawing.Point(201, 97);
            this.ciAlumno.Name = "ciAlumno";
            this.ciAlumno.Size = new System.Drawing.Size(262, 22);
            this.ciAlumno.TabIndex = 8;
            // 
            // codCurso
            // 
            this.codCurso.Location = new System.Drawing.Point(201, 156);
            this.codCurso.Name = "codCurso";
            this.codCurso.Size = new System.Drawing.Size(262, 22);
            this.codCurso.TabIndex = 9;
            // 
            // gestion
            // 
            this.gestion.Location = new System.Drawing.Point(201, 225);
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(262, 22);
            this.gestion.TabIndex = 10;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(201, 361);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(262, 22);
            this.total.TabIndex = 11;
            // 
            // dtgRegistro
            // 
            this.dtgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistro.Location = new System.Drawing.Point(506, 39);
            this.dtgRegistro.Name = "dtgRegistro";
            this.dtgRegistro.RowHeadersWidth = 51;
            this.dtgRegistro.RowTemplate.Height = 24;
            this.dtgRegistro.Size = new System.Drawing.Size(630, 422);
            this.dtgRegistro.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(147, 433);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 433);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(255, 433);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(363, 433);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 514);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgRegistro);
            this.Controls.Add(this.total);
            this.Controls.Add(this.gestion);
            this.Controls.Add(this.codCurso);
            this.Controls.Add(this.ciAlumno);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.codAsignatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codAsignatura;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox ciAlumno;
        private System.Windows.Forms.TextBox codCurso;
        private System.Windows.Forms.TextBox gestion;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.DataGridView dtgRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
    }
}