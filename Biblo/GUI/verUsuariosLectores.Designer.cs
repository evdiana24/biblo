namespace Biblo.GUI
{
    partial class verUsuariosLectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verUsuariosLectores));
            this.dtgBuscarLibros = new System.Windows.Forms.DataGridView();
            this.tIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxElegir = new System.Windows.Forms.ComboBox();
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
            this.tIdUsuario,
            this.tUsuario,
            this.tClave,
            this.tEstado,
            this.tCarnet,
            this.tFecha_Creacion,
            this.tIdLector,
            this.tIdRol});
            this.dtgBuscarLibros.Location = new System.Drawing.Point(12, 152);
            this.dtgBuscarLibros.Name = "dtgBuscarLibros";
            this.dtgBuscarLibros.ReadOnly = true;
            this.dtgBuscarLibros.Size = new System.Drawing.Size(608, 132);
            this.dtgBuscarLibros.TabIndex = 24;
            // 
            // tIdUsuario
            // 
            this.tIdUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdUsuario.DataPropertyName = "tIdUsuario";
            this.tIdUsuario.HeaderText = "ID Usuario";
            this.tIdUsuario.Name = "tIdUsuario";
            this.tIdUsuario.ReadOnly = true;
            // 
            // tUsuario
            // 
            this.tUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tUsuario.DataPropertyName = "tUsuario";
            this.tUsuario.HeaderText = "Usuario";
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.ReadOnly = true;
            // 
            // tClave
            // 
            this.tClave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tClave.DataPropertyName = "tClave";
            this.tClave.HeaderText = "Clave";
            this.tClave.Name = "tClave";
            this.tClave.ReadOnly = true;
            // 
            // tEstado
            // 
            this.tEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tEstado.DataPropertyName = "tEstado";
            this.tEstado.HeaderText = "Estado";
            this.tEstado.Name = "tEstado";
            this.tEstado.ReadOnly = true;
            // 
            // tCarnet
            // 
            this.tCarnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tCarnet.DataPropertyName = "tCarnet";
            this.tCarnet.HeaderText = "Carnet";
            this.tCarnet.Name = "tCarnet";
            this.tCarnet.ReadOnly = true;
            // 
            // tFecha_Creacion
            // 
            this.tFecha_Creacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tFecha_Creacion.DataPropertyName = "tFecha_Creacion";
            this.tFecha_Creacion.HeaderText = "Fecha Creación";
            this.tFecha_Creacion.Name = "tFecha_Creacion";
            this.tFecha_Creacion.ReadOnly = true;
            // 
            // tIdLector
            // 
            this.tIdLector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdLector.DataPropertyName = "tIdLector";
            this.tIdLector.HeaderText = "ID Lector";
            this.tIdLector.Name = "tIdLector";
            this.tIdLector.ReadOnly = true;
            // 
            // tIdRol
            // 
            this.tIdRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIdRol.DataPropertyName = "tIdRol";
            this.tIdRol.HeaderText = "ID Rol";
            this.tIdRol.Name = "tIdRol";
            this.tIdRol.ReadOnly = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(364, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 56;
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
            this.btnEditar.Location = new System.Drawing.Point(148, 307);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 41);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(364, 88);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(220, 21);
            this.txbBuscar.TabIndex = 54;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(301, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbxElegir
            // 
            this.cbxElegir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElegir.FormattingEnabled = true;
            this.cbxElegir.Location = new System.Drawing.Point(49, 87);
            this.cbxElegir.Name = "cbxElegir";
            this.cbxElegir.Size = new System.Drawing.Size(121, 24);
            this.cbxElegir.TabIndex = 52;
            // 
            // verUsuariosLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxElegir);
            this.Controls.Add(this.dtgBuscarLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verUsuariosLectores";
            this.Text = "verUsuariosLectores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgBuscarLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdRol;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxElegir;
    }
}