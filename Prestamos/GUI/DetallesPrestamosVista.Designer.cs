namespace Prestamos.GUI
{
    partial class DetallesPrestamosVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesPrestamosVista));
            this.dtgDetallesPrestamos = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallesPrestamos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDetallesPrestamos
            // 
            this.dtgDetallesPrestamos.AllowUserToAddRows = false;
            this.dtgDetallesPrestamos.AllowUserToDeleteRows = false;
            this.dtgDetallesPrestamos.AllowUserToResizeRows = false;
            this.dtgDetallesPrestamos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetallesPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDetallesPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallesPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idPrestamo,
            this.lector,
            this.idEjemplar,
            this.titulo,
            this.fecha_prestamo,
            this.fecha_devolucion});
            this.dtgDetallesPrestamos.Location = new System.Drawing.Point(39, 92);
            this.dtgDetallesPrestamos.Name = "dtgDetallesPrestamos";
            this.dtgDetallesPrestamos.ReadOnly = true;
            this.dtgDetallesPrestamos.RowHeadersVisible = false;
            this.dtgDetallesPrestamos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDetallesPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetallesPrestamos.Size = new System.Drawing.Size(897, 412);
            this.dtgDetallesPrestamos.TabIndex = 40;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "ID Detalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Width = 60;
            // 
            // idPrestamo
            // 
            this.idPrestamo.DataPropertyName = "idPrestamo";
            this.idPrestamo.HeaderText = "ID Préstamo";
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.ReadOnly = true;
            this.idPrestamo.Width = 60;
            // 
            // lector
            // 
            this.lector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lector.DataPropertyName = "lector";
            this.lector.HeaderText = "Lector";
            this.lector.Name = "lector";
            this.lector.ReadOnly = true;
            // 
            // idEjemplar
            // 
            this.idEjemplar.DataPropertyName = "idEjemplar";
            this.idEjemplar.HeaderText = "ID Ejemplar";
            this.idEjemplar.Name = "idEjemplar";
            this.idEjemplar.ReadOnly = true;
            this.idEjemplar.Width = 60;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // fecha_prestamo
            // 
            this.fecha_prestamo.DataPropertyName = "fecha_prestamo";
            this.fecha_prestamo.HeaderText = "Fecha préstamo";
            this.fecha_prestamo.Name = "fecha_prestamo";
            this.fecha_prestamo.ReadOnly = true;
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.DataPropertyName = "fecha_devolucion";
            this.fecha_devolucion.HeaderText = "Fecha devolución";
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.txbFiltro,
            this.toolStripLabel1,
            this.btnSeleccionar,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(40, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(896, 39);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltro.AutoSize = false;
            this.txbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(200, 23);
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 32);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 32);
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(838, 539);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(40, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 86;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(133, 17);
            this.lblRegistros.Text = "0 Registros Encontrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "DETALLES DE PRÉSTAMOS";
            // 
            // Detalles_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgDetallesPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detalles_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verPrestamos";
            this.Load += new System.EventHandler(this.PrestamosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallesPrestamos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgDetallesPrestamos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSeleccionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_devolucion;
    }
}