namespace Libros.GUI
{
    partial class LibroEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroEdicion));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbIdLibro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbIdEditorial = new System.Windows.Forms.TextBox();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarEditorial = new System.Windows.Forms.Button();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbIdAutor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEdicion = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txbISBN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbEdicion)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(803, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 41);
            this.btnCancelar.TabIndex = 138;
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
            this.btnGuardar.Location = new System.Drawing.Point(634, 339);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 137;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbIdLibro
            // 
            this.txbIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdLibro.Location = new System.Drawing.Point(157, 107);
            this.txbIdLibro.Name = "txbIdLibro";
            this.txbIdLibro.ReadOnly = true;
            this.txbIdLibro.Size = new System.Drawing.Size(149, 26);
            this.txbIdLibro.TabIndex = 144;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(35, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 143;
            this.label12.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 63);
            this.label1.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(121, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 38);
            this.label11.TabIndex = 141;
            this.label11.Text = "LIBROS";
            // 
            // txbIdEditorial
            // 
            this.txbIdEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdEditorial.Location = new System.Drawing.Point(156, 303);
            this.txbIdEditorial.Name = "txbIdEditorial";
            this.txbIdEditorial.ReadOnly = true;
            this.txbIdEditorial.Size = new System.Drawing.Size(150, 26);
            this.txbIdEditorial.TabIndex = 151;
            // 
            // txbAnio
            // 
            this.txbAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbAnio.Location = new System.Drawing.Point(156, 225);
            this.txbAnio.MaxLength = 4;
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(150, 26);
            this.txbAnio.TabIndex = 150;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTitulo.Location = new System.Drawing.Point(157, 184);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(316, 26);
            this.txbTitulo.TabIndex = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 148;
            this.label9.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 147;
            this.label7.Text = "ID Editorial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 146;
            this.label6.Text = "Edición:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 145;
            this.label2.Text = "Título:";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // txbEditorial
            // 
            this.txbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbEditorial.Location = new System.Drawing.Point(156, 336);
            this.txbEditorial.Name = "txbEditorial";
            this.txbEditorial.ReadOnly = true;
            this.txbEditorial.Size = new System.Drawing.Size(316, 26);
            this.txbEditorial.TabIndex = 154;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 153;
            this.label3.Text = "Editorial:";
            // 
            // btnBuscarEditorial
            // 
            this.btnBuscarEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEditorial.BackgroundImage")));
            this.btnBuscarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEditorial.Location = new System.Drawing.Point(401, 300);
            this.btnBuscarEditorial.Name = "btnBuscarEditorial";
            this.btnBuscarEditorial.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarEditorial.TabIndex = 155;
            this.btnBuscarEditorial.UseVisualStyleBackColor = true;
            this.btnBuscarEditorial.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCategoria.BackgroundImage")));
            this.btnBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(896, 146);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarCategoria.TabIndex = 160;
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // txbCategoria
            // 
            this.txbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbCategoria.Location = new System.Drawing.Point(651, 182);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(316, 26);
            this.txbCategoria.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(512, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 158;
            this.label4.Text = "Categoría:";
            // 
            // txbIdCategoria
            // 
            this.txbIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdCategoria.Location = new System.Drawing.Point(651, 149);
            this.txbIdCategoria.Name = "txbIdCategoria";
            this.txbIdCategoria.ReadOnly = true;
            this.txbIdCategoria.Size = new System.Drawing.Size(138, 26);
            this.txbIdCategoria.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(512, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 156;
            this.label5.Text = "ID Categoría:";
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAutor.BackgroundImage")));
            this.btnBuscarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarAutor.Location = new System.Drawing.Point(896, 229);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarAutor.TabIndex = 165;
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // txbAutor
            // 
            this.txbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbAutor.Location = new System.Drawing.Point(651, 265);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.ReadOnly = true;
            this.txbAutor.Size = new System.Drawing.Size(316, 26);
            this.txbAutor.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(515, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 163;
            this.label8.Text = "Autor:";
            // 
            // txbIdAutor
            // 
            this.txbIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdAutor.Location = new System.Drawing.Point(651, 232);
            this.txbIdAutor.Name = "txbIdAutor";
            this.txbIdAutor.ReadOnly = true;
            this.txbIdAutor.Size = new System.Drawing.Size(138, 26);
            this.txbIdAutor.TabIndex = 162;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(515, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 161;
            this.label10.Text = "ID Autor:";
            // 
            // txbEdicion
            // 
            this.txbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbEdicion.Location = new System.Drawing.Point(157, 263);
            this.txbEdicion.Name = "txbEdicion";
            this.txbEdicion.Size = new System.Drawing.Size(149, 26);
            this.txbEdicion.TabIndex = 166;
            this.txbEdicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(32, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 167;
            this.label13.Text = "ISBN:";
            // 
            // txbISBN
            // 
            this.txbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbISBN.Location = new System.Drawing.Point(156, 146);
            this.txbISBN.Mask = "000-00-00000-00-0";
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(150, 26);
            this.txbISBN.TabIndex = 169;
            // 
            // LibroEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 411);
            this.Controls.Add(this.txbISBN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbEdicion);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbIdAutor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarEditorial);
            this.Controls.Add(this.txbEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIdEditorial);
            this.Controls.Add(this.txbAnio);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdLibro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LibroEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbEdicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarEditorial;
        public System.Windows.Forms.TextBox txbIdLibro;
        public System.Windows.Forms.TextBox txbIdEditorial;
        public System.Windows.Forms.TextBox txbAnio;
        public System.Windows.Forms.TextBox txbTitulo;
        public System.Windows.Forms.TextBox txbEditorial;
        private System.Windows.Forms.Button btnBuscarCategoria;
        public System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbIdCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAutor;
        public System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbIdAutor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown txbEdicion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txbISBN;
    }
}