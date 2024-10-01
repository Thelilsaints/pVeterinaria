namespace pVeterinaria
{
    partial class frmRecepcion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnMascota = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTituloRecepcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(83, 251);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(87, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnMascota
            // 
            this.btnMascota.Location = new System.Drawing.Point(187, 251);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(84, 36);
            this.btnMascota.TabIndex = 0;
            this.btnMascota.Text = "MASCOTAS";
            this.btnMascota.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(287, 251);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(78, 36);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.Text = "CITAS";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(384, 251);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(81, 36);
            this.btnHistorial.TabIndex = 0;
            this.btnHistorial.Text = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(214, 371);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblTituloRecepcion
            // 
            this.lblTituloRecepcion.AutoSize = true;
            this.lblTituloRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecepcion.Location = new System.Drawing.Point(141, 86);
            this.lblTituloRecepcion.Name = "lblTituloRecepcion";
            this.lblTituloRecepcion.Size = new System.Drawing.Size(265, 42);
            this.lblTituloRecepcion.TabIndex = 1;
            this.lblTituloRecepcion.Text = "VETERINARIA";
            this.lblTituloRecepcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 459);
            this.Controls.Add(this.lblTituloRecepcion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnMascota);
            this.Controls.Add(this.btnCliente);
            this.Name = "frmRecepcion";
            this.Text = "Recepción";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTituloRecepcion;
    }
}

