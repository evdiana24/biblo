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
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbISBN = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbEdicion = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarEditorial = new System.Windows.Forms.Button();
            this.txbEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdEditorial = new System.Windows.Forms.TextBox();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdLibro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnCancelar.Location = new System.Drawing.Point(376, 413);
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
            this.btnGuardar.Location = new System.Drawing.Point(207, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 137;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // txbISBN
            // 
            this.txbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbISBN.Location = new System.Drawing.Point(180, 165);
            this.txbISBN.Mask = "000-00-00000-00-0";
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(150, 26);
            this.txbISBN.TabIndex = 203;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(56, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 202;
            this.label13.Text = "ISBN:";
            // 
            // txbEdicion
            // 
            this.txbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbEdicion.Location = new System.Drawing.Point(181, 282);
            this.txbEdicion.Name = "txbEdicion";
            this.txbEdicion.Size = new System.Drawing.Size(149, 26);
            this.txbEdicion.TabIndex = 201;
            this.txbEdicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuscarEditorial
            // 
            this.btnBuscarEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEditorial.BackgroundImage")));
            this.btnBuscarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEditorial.Location = new System.Drawing.Point(425, 319);
            this.btnBuscarEditorial.Name = "btnBuscarEditorial";
            this.btnBuscarEditorial.Size = new System.Drawing.Size(71, 34);
            this.btnBuscarEditorial.TabIndex = 200;
            this.btnBuscarEditorial.UseVisualStyleBackColor = true;
            this.btnBuscarEditorial.Click += new System.EventHandler(this.btnBuscarEditorial_Click);
            // 
            // txbEditorial
            // 
            this.txbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbEditorial.Location = new System.Drawing.Point(180, 355);
            this.txbEditorial.Name = "txbEditorial";
            this.txbEditorial.ReadOnly = true;
            this.txbEditorial.Size = new System.Drawing.Size(316, 26);
            this.txbEditorial.TabIndex = 199;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 198;
            this.label3.Text = "Editorial:";
            // 
            // txbIdEditorial
            // 
            this.txbIdEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbIdEditorial.Location = new System.Drawing.Point(180, 322);
            this.txbIdEditorial.Name = "txbIdEditorial";
            this.txbIdEditorial.ReadOnly = true;
            this.txbIdEditorial.Size = new System.Drawing.Size(150, 26);
            this.txbIdEditorial.TabIndex = 197;
            // 
            // txbAnio
            // 
            this.txbAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbAnio.Location = new System.Drawing.Point(180, 244);
            this.txbAnio.MaxLength = 4;
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(150, 26);
            this.txbAnio.TabIndex = 196;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTitulo.Location = new System.Drawing.Point(181, 203);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(316, 26);
            this.txbTitulo.TabIndex = 195;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(56, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 194;
            this.label9.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 193;
            this.label7.Text = "ID Editorial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 192;
            this.label6.Text = "Edición:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 191;
            this.label2.Text = "Título:";
            // 
            // txbIdLibro
            // 
            this.txbIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdLibro.Location = new System.Drawing.Point(181, 126);
            this.txbIdLibro.Name = "txbIdLibro";
            this.txbIdLibro.ReadOnly = true;
            this.txbIdLibro.Size = new System.Drawing.Size(149, 26);
            this.txbIdLibro.TabIndex = 190;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(59, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 189;
            this.label12.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 63);
            this.label1.TabIndex = 188;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(141, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 38);
            this.label11.TabIndex = 187;
            this.label11.Text = "LIBROS";
            // 
            // LibroEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 492);
            this.Controls.Add(this.txbISBN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbEdicion);
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
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.MaskedTextBox txbISBN;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.NumericUpDown txbEdicion;
        private System.Windows.Forms.Button btnBuscarEditorial;
        public System.Windows.Forms.TextBox txbEditorial;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbIdEditorial;
        public System.Windows.Forms.TextBox txbAnio;
        public System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIdLibro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}