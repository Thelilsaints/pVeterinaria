namespace pVeterinaria
{
    partial class frmMascotas
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
            this.dtgMascotas = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAsignarCita = new System.Windows.Forms.Button();
            this.btnMostrarMascota = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMascotas
            // 
            this.dtgMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMascotas.Location = new System.Drawing.Point(16, 356);
            this.dtgMascotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgMascotas.Name = "dtgMascotas";
            this.dtgMascotas.RowHeadersWidth = 51;
            this.dtgMascotas.Size = new System.Drawing.Size(853, 234);
            this.dtgMascotas.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(139, 608);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(248, 39);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAsignarCita
            // 
            this.btnAsignarCita.Location = new System.Drawing.Point(452, 608);
            this.btnAsignarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignarCita.Name = "btnAsignarCita";
            this.btnAsignarCita.Size = new System.Drawing.Size(248, 39);
            this.btnAsignarCita.TabIndex = 1;
            this.btnAsignarCita.Text = "ASIGNAR CITA";
            this.btnAsignarCita.UseVisualStyleBackColor = true;
            // 
            // btnMostrarMascota
            // 
            this.btnMostrarMascota.Location = new System.Drawing.Point(704, 138);
            this.btnMostrarMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarMascota.Name = "btnMostrarMascota";
            this.btnMostrarMascota.Size = new System.Drawing.Size(100, 28);
            this.btnMostrarMascota.TabIndex = 1;
            this.btnMostrarMascota.Text = "button1";
            this.btnMostrarMascota.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(704, 196);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(704, 254);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 674);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMostrarMascota);
            this.Controls.Add(this.btnAsignarCita);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgMascotas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMascotas";
            this.Text = "Mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMascotas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAsignarCita;
        private System.Windows.Forms.Button btnMostrarMascota;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}