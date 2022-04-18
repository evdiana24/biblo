namespace Biblo.GUI
{
    partial class verEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verEmpleado));
            this.dtgBuscarLibros = new System.Windows.Forms.DataGridView();
            this.tIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFecha_Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.cbxElegir = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBuscarLibros
            // 
            this.dtgBuscarLibros.AllowUserToAddRows = false;
            this.dtgBuscarLibros.AllowUserToDeleteRows = false;
            this.dtgBuscarLibros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgBuscarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdEmpleado,
            this.tNombre,
            this.tFecha_Nacimiento,
            this.tDUI,
            this.tNIT,
            this.tGenero,
            this.tTelefono,
            this.tCorreo,
            this.tDireccion,
            this.tFecha_Contrato});
            this.dtgBuscarLibros.Location = new System.Drawing.Point(12, 155);
            this.dtgBuscarLibros.Name = "dtgBuscarLibros";
            this.dtgBuscarLibros.ReadOnly = true;
            this.dtgBuscarLibros.Size = new System.Drawing.Size(608, 132);
            this.dtgBuscarLibros.TabIndex = 8;
            // 
            // tIdEmpleado
            // 
            this.tIdEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdEmpleado.DataPropertyName = "tIdEmpleado";
            this.tIdEmpleado.HeaderText = "ID Empleado";
            this.tIdEmpleado.Name = "tIdEmpleado";
            this.tIdEmpleado.ReadOnly = true;
            // 
            // tNombre
            // 
            this.tNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tNombre.DataPropertyName = "tNombre";
            this.tNombre.HeaderText = "Nombre";
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            // 
            // tFecha_Nacimiento
            // 
            this.tFecha_Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tFecha_Nacimiento.DataPropertyName = "tFecha_Nacimiento";
            this.tFecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.tFecha_Nacimiento.Name = "tFecha_Nacimiento";
            this.tFecha_Nacimiento.ReadOnly = true;
            // 
            // tDUI
            // 
            this.tDUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tDUI.DataPropertyName = "tDUI";
            this.tDUI.HeaderText = "DUI";
            this.tDUI.Name = "tDUI";
            this.tDUI.ReadOnly = true;
            // 
            // tNIT
            // 
            this.tNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tNIT.DataPropertyName = "tNIT";
            this.tNIT.HeaderText = "NIT";
            this.tNIT.Name = "tNIT";
            this.tNIT.ReadOnly = true;
            // 
            // tGenero
            // 
            this.tGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tGenero.DataPropertyName = "tGenero";
            this.tGenero.HeaderText = "Genero";
            this.tGenero.Name = "tGenero";
            this.tGenero.ReadOnly = true;
            // 
            // tTelefono
            // 
            this.tTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tTelefono.DataPropertyName = "tTelefono";
            this.tTelefono.HeaderText = "Telefono";
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.ReadOnly = true;
            // 
            // tCorreo
            // 
            this.tCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tCorreo.DataPropertyName = "tCorreo";
            this.tCorreo.HeaderText = "Correo";
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.ReadOnly = true;
            // 
            // tDireccion
            // 
            this.tDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tDireccion.DataPropertyName = "tDireccion";
            this.tDireccion.HeaderText = "Dirección";
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.ReadOnly = true;
            // 
            // tFecha_Contrato
            // 
            this.tFecha_Contrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tFecha_Contrato.DataPropertyName = "tFecha_Contrato";
            this.tFecha_Contrato.HeaderText = "Fecha de contratación";
            this.tFecha_Contrato.Name = "tFecha_Contrato";
            this.tFecha_Contrato.ReadOnly = true;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(366, 92);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(220, 21);
            this.txbBuscar.TabIndex = 54;
            // 
            // cbxElegir
            // 
            this.cbxElegir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElegir.FormattingEnabled = true;
            this.cbxElegir.Location = new System.Drawing.Point(51, 91);
            this.cbxElegir.Name = "cbxElegir";
            this.cbxElegir.Size = new System.Drawing.Size(121, 24);
            this.cbxElegir.TabIndex = 52;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(303, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(338, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(122, 305);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 41);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // verEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.cbxElegir);
            this.Controls.Add(this.dtgBuscarLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verEmpleado";
            this.Text = "verEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgBuscarLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFecha_Contrato;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.ComboBox cbxElegir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}