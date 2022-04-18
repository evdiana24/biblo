﻿namespace Biblo.GUI
{
    partial class verPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verPrestamos));
            this.dtgBuscarLibros = new System.Windows.Forms.DataGridView();
            this.tIdPrestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdUsuarioLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdUsuarioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFecha_Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tIdPrestamos,
            this.tIdUsuarioLector,
            this.tIdUsuarioEmpleado,
            this.tFecha_Prestamo});
            this.dtgBuscarLibros.Location = new System.Drawing.Point(12, 153);
            this.dtgBuscarLibros.Name = "dtgBuscarLibros";
            this.dtgBuscarLibros.ReadOnly = true;
            this.dtgBuscarLibros.Size = new System.Drawing.Size(608, 132);
            this.dtgBuscarLibros.TabIndex = 40;
            // 
            // tIdPrestamos
            // 
            this.tIdPrestamos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdPrestamos.DataPropertyName = "tIdPrestamo";
            this.tIdPrestamos.HeaderText = "ID Prestamos";
            this.tIdPrestamos.Name = "tIdPrestamos";
            this.tIdPrestamos.ReadOnly = true;
            // 
            // tIdUsuarioLector
            // 
            this.tIdUsuarioLector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdUsuarioLector.DataPropertyName = "tIdUsuarioLector";
            this.tIdUsuarioLector.HeaderText = "ID Usuario Lector";
            this.tIdUsuarioLector.Name = "tIdUsuarioLector";
            this.tIdUsuarioLector.ReadOnly = true;
            // 
            // tIdUsuarioEmpleado
            // 
            this.tIdUsuarioEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdUsuarioEmpleado.DataPropertyName = "tIdUsuarioEmpleado";
            this.tIdUsuarioEmpleado.HeaderText = "ID Usuario Empleado";
            this.tIdUsuarioEmpleado.Name = "tIdUsuarioEmpleado";
            this.tIdUsuarioEmpleado.ReadOnly = true;
            // 
            // tFecha_Prestamo
            // 
            this.tFecha_Prestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tFecha_Prestamo.DataPropertyName = "tFecha_Prestamo";
            this.tFecha_Prestamo.HeaderText = "Fecha Prestamos";
            this.tFecha_Prestamo.Name = "tFecha_Prestamo";
            this.tFecha_Prestamo.ReadOnly = true;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(365, 92);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(220, 21);
            this.txbBuscar.TabIndex = 39;
            // 
            // cbxElegir
            // 
            this.cbxElegir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElegir.FormattingEnabled = true;
            this.cbxElegir.Items.AddRange(new object[] {
            "Autor",
            "Categoria",
            "Nombre"});
            this.cbxElegir.Location = new System.Drawing.Point(50, 91);
            this.cbxElegir.Name = "cbxElegir";
            this.cbxElegir.Size = new System.Drawing.Size(121, 24);
            this.cbxElegir.TabIndex = 37;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(302, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 54;
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
            this.btnCancelar.Location = new System.Drawing.Point(335, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 58;
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
            this.btnEditar.Location = new System.Drawing.Point(119, 305);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 41);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // verPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgBuscarLibros);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.cbxElegir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verPrestamos";
            this.Text = "verPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgBuscarLibros;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.ComboBox cbxElegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdUsuarioLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdUsuarioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFecha_Prestamo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}