namespace EDUCACION
{
    partial class Crear_Actividad
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
            this.addArchivo = new System.Windows.Forms.Button();
            this.subirArchivo = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.RichTextBox();
            this.nomArchivo = new System.Windows.Forms.TextBox();
            this.actividad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 16);
            this.label.TabIndex = 0;
            this.label.Text = "ARCHIVO:";
            // 
            // addArchivo
            // 
            this.addArchivo.Location = new System.Drawing.Point(65, 155);
            this.addArchivo.Name = "addArchivo";
            this.addArchivo.Size = new System.Drawing.Size(132, 23);
            this.addArchivo.TabIndex = 2;
            this.addArchivo.Text = "AÑADIR ARCHIVO";
            this.addArchivo.UseVisualStyleBackColor = true;
            this.addArchivo.Click += new System.EventHandler(this.addArchivo_Click);
            // 
            // subirArchivo
            // 
            this.subirArchivo.Location = new System.Drawing.Point(501, 501);
            this.subirArchivo.Name = "subirArchivo";
            this.subirArchivo.Size = new System.Drawing.Size(154, 23);
            this.subirArchivo.TabIndex = 3;
            this.subirArchivo.Text = "SUBIR ACTIVIDAD";
            this.subirArchivo.UseVisualStyleBackColor = true;
            this.subirArchivo.Click += new System.EventHandler(this.subirArchivo_Click);
            // 
            // archivo
            // 
            this.archivo.AutoSize = true;
            this.archivo.Location = new System.Drawing.Point(296, 36);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(10, 16);
            this.archivo.TabIndex = 4;
            this.archivo.Text = ".";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(62, 255);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(165, 16);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "NOMBRE DE ACTIVIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE DEL ARCHIVO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "DETALLE:";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(299, 337);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(356, 114);
            this.detalle.TabIndex = 11;
            this.detalle.Text = "";
            // 
            // nomArchivo
            // 
            this.nomArchivo.Location = new System.Drawing.Point(299, 85);
            this.nomArchivo.Name = "nomArchivo";
            this.nomArchivo.Size = new System.Drawing.Size(356, 22);
            this.nomArchivo.TabIndex = 5;
            // 
            // actividad
            // 
            this.actividad.Location = new System.Drawing.Point(299, 252);
            this.actividad.Name = "actividad";
            this.actividad.Size = new System.Drawing.Size(356, 22);
            this.actividad.TabIndex = 10;
            // 
            // Crear_Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 557);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.actividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nomArchivo);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.subirArchivo);
            this.Controls.Add(this.addArchivo);
            this.Controls.Add(this.label);
            this.Name = "Crear_Actividad";
            this.Text = "Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button addArchivo;
        private System.Windows.Forms.Button subirArchivo;
        private System.Windows.Forms.Label archivo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detalle;
        private System.Windows.Forms.TextBox nomArchivo;
        private System.Windows.Forms.TextBox actividad;
    }
}