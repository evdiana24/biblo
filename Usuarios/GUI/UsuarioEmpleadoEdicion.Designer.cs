namespace Usuarios.GUI
{
    partial class UsuarioEmpleadoEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioEmpleadoEdicion));
            this.txbClave = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbRepiteClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbClave
            // 
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbClave.Location = new System.Drawing.Point(276, 162);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '●';
            this.txbClave.Size = new System.Drawing.Size(312, 26);
            this.txbClave.TabIndex = 176;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbUsuario.Location = new System.Drawing.Point(361, 124);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(225, 26);
            this.txbUsuario.TabIndex = 175;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 174;
            this.label9.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 173;
            this.label2.Text = "Usuario:";
            // 
            // txbIdUsuario
            // 
            this.txbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdUsuario.Location = new System.Drawing.Point(99, 124);
            this.txbIdUsuario.Name = "txbIdUsuario";
            this.txbIdUsuario.ReadOnly = true;
            this.txbIdUsuario.Size = new System.Drawing.Size(139, 26);
            this.txbIdUsuario.TabIndex = 172;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(61, 124);
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
            this.label1.Location = new System.Drawing.Point(50, 34);
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
            this.label11.Location = new System.Drawing.Point(131, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(364, 38);
            this.label11.TabIndex = 169;
            this.label11.Text = "USUARIOS EMPLEADOS";
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
            this.btnCancelar.Location = new System.Drawing.Point(435, 440);
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
            this.btnGuardar.Location = new System.Drawing.Point(266, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 167;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Suspendido"});
            this.cmbEstado.Location = new System.Drawing.Point(149, 238);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(139, 28);
            this.cmbEstado.TabIndex = 166;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 165;
            this.label4.Text = "Estado :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 183;
            this.label5.Text = "Fecha de creación:";
            // 
            // txbIdEmpleado
            // 
            this.txbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdEmpleado.Location = new System.Drawing.Point(264, 319);
            this.txbIdEmpleado.Name = "txbIdEmpleado";
            this.txbIdEmpleado.ReadOnly = true;
            this.txbIdEmpleado.Size = new System.Drawing.Size(139, 26);
            this.txbIdEmpleado.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 185;
            this.label3.Text = "ID de Empleado:";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // txbRepiteClave
            // 
            this.txbRepiteClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbRepiteClave.Location = new System.Drawing.Point(276, 199);
            this.txbRepiteClave.Name = "txbRepiteClave";
            this.txbRepiteClave.PasswordChar = '●';
            this.txbRepiteClave.Size = new System.Drawing.Size(312, 26);
            this.txbRepiteClave.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 23);
            this.label8.TabIndex = 211;
            this.label8.Text = "Repita la contraseña:";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(264, 352);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(324, 26);
            this.txbEmpleado.TabIndex = 214;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 213;
            this.label7.Text = "Empleado:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 23);
            this.label10.TabIndex = 215;
            this.label10.Text = "Rol:";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.BackgroundImage")));
            this.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(516, 315);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarEmpleado.TabIndex = 217;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Activo",
            "Suspendido"});
            this.cmbRol.Location = new System.Drawing.Point(264, 388);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(324, 28);
            this.cmbRol.TabIndex = 218;
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaCreacion.Location = new System.Drawing.Point(264, 279);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(324, 26);
            this.dtFechaCreacion.TabIndex = 219;
            // 
            // UsuarioEmpleadoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 513);
            this.Controls.Add(this.dtFechaCreacion);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbRepiteClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbIdEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdUsuario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsuarioEmpleadoEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        public System.Windows.Forms.TextBox txbClave;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbIdUsuario;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.TextBox txbIdEmpleado;
        public System.Windows.Forms.TextBox txbEmpleado;
        public System.Windows.Forms.TextBox txbRepiteClave;
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.DateTimePicker dtFechaCreacion;
    }
}