namespace Prestamos.GUI
{
    partial class PrestamoEdicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamoEdicion));
            this.txbIdPrestamo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnBuscarLector = new System.Windows.Forms.Button();
            this.txbUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbUsuarioLector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIdUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdUsuarioLector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIdPrestamo
            // 
            this.txbIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdPrestamo.Location = new System.Drawing.Point(279, 135);
            this.txbIdPrestamo.Name = "txbIdPrestamo";
            this.txbIdPrestamo.ReadOnly = true;
            this.txbIdPrestamo.Size = new System.Drawing.Size(139, 26);
            this.txbIdPrestamo.TabIndex = 172;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 171;
            this.label12.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 63);
            this.label1.TabIndex = 170;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(134, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 38);
            this.label11.TabIndex = 169;
            this.label11.Text = "PRÉSTAMOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(424, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 168;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(255, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 167;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.CustomFormat = "dd/MM/yyyy";
            this.dtFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaPrestamo.Location = new System.Drawing.Point(279, 331);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(170, 26);
            this.dtFechaPrestamo.TabIndex = 182;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 23);
            this.label5.TabIndex = 181;
            this.label5.Text = "Fecha del préstamo:";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.BackgroundImage")));
            this.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(506, 252);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarEmpleado.TabIndex = 196;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnBuscarLector
            // 
            this.btnBuscarLector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarLector.BackgroundImage")));
            this.btnBuscarLector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarLector.Location = new System.Drawing.Point(506, 174);
            this.btnBuscarLector.Name = "btnBuscarLector";
            this.btnBuscarLector.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarLector.TabIndex = 195;
            this.btnBuscarLector.UseVisualStyleBackColor = true;
            this.btnBuscarLector.Click += new System.EventHandler(this.btnBuscarLector_Click);
            // 
            // txbUsuarioEmpleado
            // 
            this.txbUsuarioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbUsuarioEmpleado.Location = new System.Drawing.Point(279, 290);
            this.txbUsuarioEmpleado.Name = "txbUsuarioEmpleado";
            this.txbUsuarioEmpleado.Size = new System.Drawing.Size(298, 26);
            this.txbUsuarioEmpleado.TabIndex = 194;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 193;
            this.label7.Text = "Usuario empleado:";
            // 
            // txbUsuarioLector
            // 
            this.txbUsuarioLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbUsuarioLector.Location = new System.Drawing.Point(279, 214);
            this.txbUsuarioLector.Name = "txbUsuarioLector";
            this.txbUsuarioLector.Size = new System.Drawing.Size(298, 26);
            this.txbUsuarioLector.TabIndex = 192;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 191;
            this.label6.Text = "Usuario lector:";
            // 
            // txbIdUsuarioEmpleado
            // 
            this.txbIdUsuarioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdUsuarioEmpleado.Location = new System.Drawing.Point(279, 252);
            this.txbIdUsuarioEmpleado.Name = "txbIdUsuarioEmpleado";
            this.txbIdUsuarioEmpleado.ReadOnly = true;
            this.txbIdUsuarioEmpleado.Size = new System.Drawing.Size(139, 26);
            this.txbIdUsuarioEmpleado.TabIndex = 190;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 189;
            this.label3.Text = "ID usuario empleado:";
            // 
            // txbIdUsuarioLector
            // 
            this.txbIdUsuarioLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdUsuarioLector.Location = new System.Drawing.Point(279, 177);
            this.txbIdUsuarioLector.Name = "txbIdUsuarioLector";
            this.txbIdUsuarioLector.ReadOnly = true;
            this.txbIdUsuarioLector.Size = new System.Drawing.Size(139, 26);
            this.txbIdUsuarioLector.TabIndex = 188;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 187;
            this.label4.Text = "ID usuario lector:";
            // 
            // PrestamoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 469);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.btnBuscarLector);
            this.Controls.Add(this.txbUsuarioEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbUsuarioLector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbIdUsuarioEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIdUsuarioLector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFechaPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIdPrestamo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrestamoEdicion";
            this.Text = "Préstamo";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnBuscarLector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbIdPrestamo;
        public System.Windows.Forms.DateTimePicker dtFechaPrestamo;
        public System.Windows.Forms.TextBox txbUsuarioEmpleado;
        public System.Windows.Forms.TextBox txbUsuarioLector;
        public System.Windows.Forms.TextBox txbIdUsuarioEmpleado;
        public System.Windows.Forms.TextBox txbIdUsuarioLector;
    }
}