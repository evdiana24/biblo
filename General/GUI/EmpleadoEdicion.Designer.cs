namespace General.GUI
{
    partial class EmpleadoEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoEdicion));
            this.txbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbDUI = new System.Windows.Forms.TextBox();
            this.txbNIT = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIdEmpleado
            // 
            this.txbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdEmpleado.Location = new System.Drawing.Point(148, 94);
            this.txbIdEmpleado.Name = "txbIdEmpleado";
            this.txbIdEmpleado.ReadOnly = true;
            this.txbIdEmpleado.Size = new System.Drawing.Size(90, 26);
            this.txbIdEmpleado.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 163;
            this.label12.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 63);
            this.label1.TabIndex = 162;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(112, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 38);
            this.label11.TabIndex = 161;
            this.label11.Text = "EMPLEADOS";
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
            this.btnCancelar.Location = new System.Drawing.Point(444, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 160;
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
            this.btnGuardar.Location = new System.Drawing.Point(275, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 159;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFechaContratacion
            // 
            this.dtFechaContratacion.CustomFormat = "dd/MM/yyyy";
            this.dtFechaContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaContratacion.Location = new System.Drawing.Point(290, 366);
            this.dtFechaContratacion.Name = "dtFechaContratacion";
            this.dtFechaContratacion.Size = new System.Drawing.Size(170, 26);
            this.dtFechaContratacion.TabIndex = 158;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(290, 326);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(170, 26);
            this.dtFechaNacimiento.TabIndex = 157;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(148, 247);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(147, 28);
            this.cmbGenero.TabIndex = 156;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTelefono.Location = new System.Drawing.Point(446, 247);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(157, 26);
            this.txbTelefono.TabIndex = 155;
            // 
            // txbDUI
            // 
            this.txbDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbDUI.Location = new System.Drawing.Point(147, 208);
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.Size = new System.Drawing.Size(148, 26);
            this.txbDUI.TabIndex = 154;
            // 
            // txbNIT
            // 
            this.txbNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbNIT.Location = new System.Drawing.Point(446, 211);
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.Size = new System.Drawing.Size(157, 26);
            this.txbNIT.TabIndex = 153;
            // 
            // txbCorreo
            // 
            this.txbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbCorreo.Location = new System.Drawing.Point(147, 287);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(303, 26);
            this.txbCorreo.TabIndex = 152;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbDireccion.Location = new System.Drawing.Point(148, 170);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(454, 26);
            this.txbDireccion.TabIndex = 151;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbNombre.Location = new System.Drawing.Point(234, 131);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(368, 26);
            this.txbNombre.TabIndex = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 23);
            this.label10.TabIndex = 149;
            this.label10.Text = "Fecha de contratación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 148;
            this.label9.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 147;
            this.label8.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(343, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 146;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 145;
            this.label6.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(387, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 144;
            this.label5.Text = "NIT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 143;
            this.label4.Text = "DUI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 142;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 141;
            this.label2.Text = "Nombre completo:";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // EmpleadoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 493);
            this.Controls.Add(this.txbIdEmpleado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtFechaContratacion);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDUI);
            this.Controls.Add(this.txbNIT);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpleadoEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.TextBox txbIdEmpleado;
        public System.Windows.Forms.DateTimePicker dtFechaContratacion;
        public System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.TextBox txbTelefono;
        public System.Windows.Forms.TextBox txbDUI;
        public System.Windows.Forms.TextBox txbNIT;
        public System.Windows.Forms.TextBox txbCorreo;
        public System.Windows.Forms.TextBox txbDireccion;
        public System.Windows.Forms.TextBox txbNombre;
    }
}