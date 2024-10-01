namespace pVeterinaria
{
    partial class frmClientes
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
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnMostrarCliente = new System.Windows.Forms.Button();
            this.btnAsignarCita = new System.Windows.Forms.Button();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.btnRegresarCliente = new System.Windows.Forms.Button();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidosCliente = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(21, 309);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(605, 156);
            this.dtgClientes.TabIndex = 0;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Location = new System.Drawing.Point(21, 262);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(77, 28);
            this.btnAgregarClientes.TabIndex = 1;
            this.btnAgregarClientes.Text = "AGREGAR";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(125, 262);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(77, 28);
            this.btnEliminarCliente.TabIndex = 1;
            this.btnEliminarCliente.Text = "ELIMINAR";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCliente
            // 
            this.btnMostrarCliente.Location = new System.Drawing.Point(234, 262);
            this.btnMostrarCliente.Name = "btnMostrarCliente";
            this.btnMostrarCliente.Size = new System.Drawing.Size(77, 28);
            this.btnMostrarCliente.TabIndex = 1;
            this.btnMostrarCliente.Text = "MOSTRAR";
            this.btnMostrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAsignarCita
            // 
            this.btnAsignarCita.Location = new System.Drawing.Point(341, 262);
            this.btnAsignarCita.Name = "btnAsignarCita";
            this.btnAsignarCita.Size = new System.Drawing.Size(77, 28);
            this.btnAsignarCita.TabIndex = 1;
            this.btnAsignarCita.Text = "ASIGNAR CITA";
            this.btnAsignarCita.UseVisualStyleBackColor = true;
            this.btnAsignarCita.Click += new System.EventHandler(this.btnAsignarCitaCliente_Click);
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Location = new System.Drawing.Point(451, 262);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(77, 28);
            this.btnAgregarMascota.TabIndex = 1;
            this.btnAgregarMascota.Text = "AGREGAR MASCOTA";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente
            // 
            this.btnRegresarCliente.Location = new System.Drawing.Point(549, 262);
            this.btnRegresarCliente.Name = "btnRegresarCliente";
            this.btnRegresarCliente.Size = new System.Drawing.Size(77, 28);
            this.btnRegresarCliente.TabIndex = 1;
            this.btnRegresarCliente.Text = "REGRESAR";
            this.btnRegresarCliente.UseVisualStyleBackColor = true;
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaCliente.Location = new System.Drawing.Point(168, 79);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(53, 16);
            this.lblCedulaCliente.TabIndex = 2;
            this.lblCedulaCliente.Text = "Cédula:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(155, 105);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(66, 16);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidosCliente
            // 
            this.lblApellidosCliente.AutoSize = true;
            this.lblApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosCliente.Location = new System.Drawing.Point(154, 135);
            this.lblApellidosCliente.Name = "lblApellidosCliente";
            this.lblApellidosCliente.Size = new System.Drawing.Size(67, 16);
            this.lblApellidosCliente.TabIndex = 2;
            this.lblApellidosCliente.Text = "Apellidos:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(169, 167);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 16);
            this.lblCelular.TabIndex = 2;
            this.lblCelular.Text = "Celular:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(173, 198);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(48, 16);
            this.lblEmailCliente.TabIndex = 2;
            this.lblEmailCliente.Text = "E-Mail:";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(154, 225);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionCliente.TabIndex = 2;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(261, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(130, 31);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(221, 75);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(246, 20);
            this.txtCedulaCliente.TabIndex = 3;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Location = new System.Drawing.Point(221, 101);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(246, 20);
            this.txtNombresCliente.TabIndex = 3;
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(221, 131);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(246, 20);
            this.txtApellidosCliente.TabIndex = 3;
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(221, 163);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(246, 20);
            this.txtCelularCliente.TabIndex = 3;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(221, 197);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(246, 20);
            this.txtEmailCliente.TabIndex = 3;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(221, 225);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(246, 20);
            this.txtDireccionCliente.TabIndex = 3;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 486);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.txtApellidosCliente);
            this.Controls.Add(this.txtNombresCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblApellidosCliente);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCedulaCliente);
            this.Controls.Add(this.btnRegresarCliente);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.btnAsignarCita);
            this.Controls.Add(this.btnMostrarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.dtgClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnMostrarCliente;
        private System.Windows.Forms.Button btnAsignarCita;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Button btnRegresarCliente;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidosCliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
    }
}