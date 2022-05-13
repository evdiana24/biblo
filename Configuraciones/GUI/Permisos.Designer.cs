namespace Configuraciones.GUI
{
    partial class Permisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(39, 72);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(305, 24);
            this.cmbRol.TabIndex = 23;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cbbRol_SelectedIndexChanged);
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignado,
            this.idOpcion,
            this.opcion,
            this.idPermiso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatos.Location = new System.Drawing.Point(39, 105);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(897, 412);
            this.dtgDatos.TabIndex = 24;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            // 
            // Asignado
            // 
            this.Asignado.DataPropertyName = "Asignado";
            this.Asignado.FalseValue = "0";
            this.Asignado.HeaderText = "Selección";
            this.Asignado.IndeterminateValue = "0";
            this.Asignado.Name = "Asignado";
            this.Asignado.ReadOnly = true;
            this.Asignado.TrueValue = "1";
            this.Asignado.Width = 70;
            // 
            // idOpcion
            // 
            this.idOpcion.DataPropertyName = "idOpcion";
            this.idOpcion.HeaderText = "ID";
            this.idOpcion.Name = "idOpcion";
            this.idOpcion.ReadOnly = true;
            this.idOpcion.Width = 80;
            // 
            // opcion
            // 
            this.opcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opcion.DataPropertyName = "opcion";
            this.opcion.HeaderText = "Opción";
            this.opcion.Name = "opcion";
            this.opcion.ReadOnly = true;
            // 
            // idPermiso
            // 
            this.idPermiso.DataPropertyName = "idPermiso";
            this.idPermiso.HeaderText = "IDPermiso";
            this.idPermiso.Name = "idPermiso";
            this.idPermiso.ReadOnly = true;
            this.idPermiso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 141;
            this.label2.Text = "PERMISOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 142;
            this.label1.Text = "ROL SELECCIONADO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(838, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 143;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.cmbRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}