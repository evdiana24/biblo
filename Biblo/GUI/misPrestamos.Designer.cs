namespace Biblo.GUI
{
    partial class misPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(misPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarPrest = new System.Windows.Forms.TextBox();
            this.dtgMisPrestamos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMisPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(224, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIS PRESTAMOS";
            // 
            // txbBuscarPrest
            // 
            this.txbBuscarPrest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarPrest.Location = new System.Drawing.Point(212, 108);
            this.txbBuscarPrest.Name = "txbBuscarPrest";
            this.txbBuscarPrest.Size = new System.Drawing.Size(236, 21);
            this.txbBuscarPrest.TabIndex = 2;
            // 
            // dtgMisPrestamos
            // 
            this.dtgMisPrestamos.AllowUserToAddRows = false;
            this.dtgMisPrestamos.AllowUserToDeleteRows = false;
            this.dtgMisPrestamos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgMisPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMisPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo});
            this.dtgMisPrestamos.Location = new System.Drawing.Point(12, 176);
            this.dtgMisPrestamos.Name = "dtgMisPrestamos";
            this.dtgMisPrestamos.ReadOnly = true;
            this.dtgMisPrestamos.Size = new System.Drawing.Size(608, 151);
            this.dtgMisPrestamos.TabIndex = 3;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "tTitulo";
            this.Titulo.HeaderText = "TITULO";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(139, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // misPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgMisPrestamos);
            this.Controls.Add(this.txbBuscarPrest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "misPrestamos";
            this.Text = "misPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMisPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarPrest;
        private System.Windows.Forms.DataGridView dtgMisPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.Button btnBuscar;
    }
}