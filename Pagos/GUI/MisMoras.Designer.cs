namespace Pagos.GUI
{
    partial class MisMoras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisMoras));
            this.dtgPagosGestion = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagosGestion)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPagosGestion
            // 
            this.dtgPagosGestion.AllowUserToAddRows = false;
            this.dtgPagosGestion.AllowUserToDeleteRows = false;
            this.dtgPagosGestion.AllowUserToResizeRows = false;
            this.dtgPagosGestion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPagosGestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPagosGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagosGestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.fecha_prestamo,
            this.fecha_devolucion,
            this.totalMora,
            this.estado});
            this.dtgPagosGestion.Location = new System.Drawing.Point(39, 60);
            this.dtgPagosGestion.Name = "dtgPagosGestion";
            this.dtgPagosGestion.ReadOnly = true;
            this.dtgPagosGestion.RowHeadersVisible = false;
            this.dtgPagosGestion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPagosGestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPagosGestion.Size = new System.Drawing.Size(897, 444);
            this.dtgPagosGestion.TabIndex = 48;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.label1.Location = new System.Drawing.Point(453, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "MIS MORAS";
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Libro";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // fecha_prestamo
            // 
            this.fecha_prestamo.DataPropertyName = "fecha_prestamo";
            this.fecha_prestamo.HeaderText = "Fecha del préstamo";
            this.fecha_prestamo.Name = "fecha_prestamo";
            this.fecha_prestamo.ReadOnly = true;
            this.fecha_prestamo.Width = 150;
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.DataPropertyName = "fecha_devolucion";
            this.fecha_devolucion.HeaderText = "Fecha a devolver";
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.ReadOnly = true;
            this.fecha_devolucion.Width = 150;
            // 
            // totalMora
            // 
            this.totalMora.DataPropertyName = "totalMora";
            this.totalMora.HeaderText = "Total";
            this.totalMora.Name = "totalMora";
            this.totalMora.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 150;
            // 
            // MisMoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgPagosGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisMoras";
            this.Text = "verPagos";
            this.Load += new System.EventHandler(this.PagosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagosGestion)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgPagosGestion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}