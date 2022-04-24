﻿namespace Biblo.GUI
{
    partial class verLectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verLectores));
            this.dtgBuscarLibros = new System.Windows.Forms.DataGridView();
            this.tIdLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBuscarLibros
            // 
            this.dtgBuscarLibros.AllowUserToAddRows = false;
            this.dtgBuscarLibros.AllowUserToDeleteRows = false;
            this.dtgBuscarLibros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgBuscarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdLector,
            this.tNombre,
            this.tFecha_Nacimiento,
            this.tCorreo,
            this.tTelefono,
            this.tGenero,
            this.tDireccion});
            this.dtgBuscarLibros.Location = new System.Drawing.Point(50, 112);
            this.dtgBuscarLibros.Name = "dtgBuscarLibros";
            this.dtgBuscarLibros.ReadOnly = true;
            this.dtgBuscarLibros.Size = new System.Drawing.Size(708, 412);
            this.dtgBuscarLibros.TabIndex = 16;
            // 
            // tIdLector
            // 
            this.tIdLector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdLector.DataPropertyName = "tIdLector";
            this.tIdLector.HeaderText = "ID Lector";
            this.tIdLector.Name = "tIdLector";
            this.tIdLector.ReadOnly = true;
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
            this.tFecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.tFecha_Nacimiento.Name = "tFecha_Nacimiento";
            this.tFecha_Nacimiento.ReadOnly = true;
            // 
            // tCorreo
            // 
            this.tCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tCorreo.DataPropertyName = "tCorreo";
            this.tCorreo.HeaderText = "Correo";
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.ReadOnly = true;
            // 
            // tTelefono
            // 
            this.tTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tTelefono.DataPropertyName = "tTelefono";
            this.tTelefono.HeaderText = "Telefono";
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.ReadOnly = true;
            // 
            // tGenero
            // 
            this.tGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tGenero.DataPropertyName = "tGenero";
            this.tGenero.HeaderText = "Genero";
            this.tGenero.Name = "tGenero";
            this.tGenero.ReadOnly = true;
            // 
            // tDireccion
            // 
            this.tDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tDireccion.DataPropertyName = "tDireccion";
            this.tDireccion.HeaderText = "Dirección";
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnAgregar,
            this.toolStripSeparator2,
            this.btnEditar,
            this.toolStripSeparator3,
            this.btnEliminar,
            this.toolStripSeparator4,
            this.txbFiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(50, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(708, 39);
            this.toolStrip1.TabIndex = 82;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 32);
            this.btnAgregar.Text = "Agregar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 32);
            this.btnEditar.Text = "Editar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 32);
            this.btnEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.AutoSize = false;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 32);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // verLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 572);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgBuscarLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verLectores";
            this.Text = "verLectores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgBuscarLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDireccion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox txbFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}