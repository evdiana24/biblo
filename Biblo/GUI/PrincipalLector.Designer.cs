namespace Biblo.GUI
{
    partial class PrincipalLector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalLector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.btnBuscarlibro = new System.Windows.Forms.Button();
            this.panelBuscarLibro = new System.Windows.Forms.Panel();
            this.btnPorAutor = new System.Windows.Forms.Button();
            this.btnPorCategoria = new System.Windows.Forms.Button();
            this.btnPortitulo = new System.Windows.Forms.Button();
            this.btnPorEditorial = new System.Windows.Forms.Button();
            this.btnMisPrestamos = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.panelPagos = new System.Windows.Forms.Panel();
            this.btnHistorialPagos = new System.Windows.Forms.Button();
            this.btnMoras = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.btnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBuscarLibro.SuspendLayout();
            this.panelPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.panelPagos);
            this.panel1.Controls.Add(this.btnPagos);
            this.panel1.Controls.Add(this.btnMisPrestamos);
            this.panel1.Controls.Add(this.panelBuscarLibro);
            this.panel1.Controls.Add(this.btnBuscarlibro);
            this.panel1.Controls.Add(this.btnMiPerfil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 672);
            this.panel1.TabIndex = 0;
            // 
            // btnBarraTitulo
            // 
            this.btnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBarraTitulo.Controls.Add(this.btnRestaurar);
            this.btnBarraTitulo.Controls.Add(this.btnMinimizar);
            this.btnBarraTitulo.Controls.Add(this.btnMaximizar);
            this.btnBarraTitulo.Controls.Add(this.btnSalir);
            this.btnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarraTitulo.Location = new System.Drawing.Point(274, 0);
            this.btnBarraTitulo.Name = "btnBarraTitulo";
            this.btnBarraTitulo.Size = new System.Drawing.Size(904, 35);
            this.btnBarraTitulo.TabIndex = 1;
            this.btnBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBarraTitulo_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(836, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(805, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(836, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(867, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 133);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lector";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMiPerfil.FlatAppearance.BorderSize = 0;
            this.btnMiPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMiPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiPerfil.Location = new System.Drawing.Point(0, 133);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMiPerfil.Size = new System.Drawing.Size(274, 45);
            this.btnMiPerfil.TabIndex = 3;
            this.btnMiPerfil.Text = "Mi perfil";
            this.btnMiPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiPerfil.UseVisualStyleBackColor = true;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // btnBuscarlibro
            // 
            this.btnBuscarlibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarlibro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarlibro.FlatAppearance.BorderSize = 0;
            this.btnBuscarlibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnBuscarlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarlibro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarlibro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarlibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarlibro.Location = new System.Drawing.Point(0, 178);
            this.btnBuscarlibro.Name = "btnBuscarlibro";
            this.btnBuscarlibro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBuscarlibro.Size = new System.Drawing.Size(274, 45);
            this.btnBuscarlibro.TabIndex = 4;
            this.btnBuscarlibro.Text = "Buscar libro";
            this.btnBuscarlibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarlibro.UseVisualStyleBackColor = true;
            this.btnBuscarlibro.Click += new System.EventHandler(this.btnBuscarlibro_Click);
            // 
            // panelBuscarLibro
            // 
            this.panelBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelBuscarLibro.Controls.Add(this.btnPorEditorial);
            this.panelBuscarLibro.Controls.Add(this.btnPorAutor);
            this.panelBuscarLibro.Controls.Add(this.btnPorCategoria);
            this.panelBuscarLibro.Controls.Add(this.btnPortitulo);
            this.panelBuscarLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscarLibro.Location = new System.Drawing.Point(0, 223);
            this.panelBuscarLibro.Name = "panelBuscarLibro";
            this.panelBuscarLibro.Size = new System.Drawing.Size(274, 169);
            this.panelBuscarLibro.TabIndex = 5;
            // 
            // btnPorAutor
            // 
            this.btnPorAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorAutor.FlatAppearance.BorderSize = 0;
            this.btnPorAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorAutor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPorAutor.Location = new System.Drawing.Point(0, 80);
            this.btnPorAutor.Name = "btnPorAutor";
            this.btnPorAutor.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnPorAutor.Size = new System.Drawing.Size(274, 40);
            this.btnPorAutor.TabIndex = 2;
            this.btnPorAutor.Text = "Por autor";
            this.btnPorAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorAutor.UseVisualStyleBackColor = true;
            this.btnPorAutor.Click += new System.EventHandler(this.btnPorAutor_Click);
            // 
            // btnPorCategoria
            // 
            this.btnPorCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorCategoria.FlatAppearance.BorderSize = 0;
            this.btnPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPorCategoria.Location = new System.Drawing.Point(0, 40);
            this.btnPorCategoria.Name = "btnPorCategoria";
            this.btnPorCategoria.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnPorCategoria.Size = new System.Drawing.Size(274, 40);
            this.btnPorCategoria.TabIndex = 1;
            this.btnPorCategoria.Text = "Por categoría";
            this.btnPorCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorCategoria.UseVisualStyleBackColor = true;
            this.btnPorCategoria.Click += new System.EventHandler(this.btnPorCategoria_Click);
            // 
            // btnPortitulo
            // 
            this.btnPortitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPortitulo.FlatAppearance.BorderSize = 0;
            this.btnPortitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortitulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPortitulo.Location = new System.Drawing.Point(0, 0);
            this.btnPortitulo.Name = "btnPortitulo";
            this.btnPortitulo.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnPortitulo.Size = new System.Drawing.Size(274, 40);
            this.btnPortitulo.TabIndex = 0;
            this.btnPortitulo.Text = "Por título";
            this.btnPortitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPortitulo.UseVisualStyleBackColor = true;
            this.btnPortitulo.Click += new System.EventHandler(this.btnPortitulo_Click);
            // 
            // btnPorEditorial
            // 
            this.btnPorEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorEditorial.FlatAppearance.BorderSize = 0;
            this.btnPorEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorEditorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPorEditorial.Location = new System.Drawing.Point(0, 120);
            this.btnPorEditorial.Name = "btnPorEditorial";
            this.btnPorEditorial.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnPorEditorial.Size = new System.Drawing.Size(274, 40);
            this.btnPorEditorial.TabIndex = 3;
            this.btnPorEditorial.Text = "Por editorial";
            this.btnPorEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorEditorial.UseVisualStyleBackColor = true;
            this.btnPorEditorial.Click += new System.EventHandler(this.btnPorEditorial_Click);
            // 
            // btnMisPrestamos
            // 
            this.btnMisPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMisPrestamos.FlatAppearance.BorderSize = 0;
            this.btnMisPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnMisPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPrestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMisPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPrestamos.Location = new System.Drawing.Point(0, 392);
            this.btnMisPrestamos.Name = "btnMisPrestamos";
            this.btnMisPrestamos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMisPrestamos.Size = new System.Drawing.Size(274, 45);
            this.btnMisPrestamos.TabIndex = 6;
            this.btnMisPrestamos.Text = "Mis préstamos";
            this.btnMisPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPrestamos.UseVisualStyleBackColor = true;
            this.btnMisPrestamos.Click += new System.EventHandler(this.btnMisPrestamos_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 437);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(274, 45);
            this.btnPagos.TabIndex = 7;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // panelPagos
            // 
            this.panelPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelPagos.Controls.Add(this.btnHistorialPagos);
            this.panelPagos.Controls.Add(this.btnMoras);
            this.panelPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPagos.Location = new System.Drawing.Point(0, 482);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(274, 88);
            this.panelPagos.TabIndex = 8;
            // 
            // btnHistorialPagos
            // 
            this.btnHistorialPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialPagos.FlatAppearance.BorderSize = 0;
            this.btnHistorialPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistorialPagos.Location = new System.Drawing.Point(0, 40);
            this.btnHistorialPagos.Name = "btnHistorialPagos";
            this.btnHistorialPagos.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnHistorialPagos.Size = new System.Drawing.Size(274, 40);
            this.btnHistorialPagos.TabIndex = 1;
            this.btnHistorialPagos.Text = "Ver historial de pagos";
            this.btnHistorialPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPagos.UseVisualStyleBackColor = true;
            this.btnHistorialPagos.Click += new System.EventHandler(this.btnHistorialPagos_Click);
            // 
            // btnMoras
            // 
            this.btnMoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoras.FlatAppearance.BorderSize = 0;
            this.btnMoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMoras.Location = new System.Drawing.Point(0, 0);
            this.btnMoras.Name = "btnMoras";
            this.btnMoras.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnMoras.Size = new System.Drawing.Size(274, 40);
            this.btnMoras.TabIndex = 0;
            this.btnMoras.Text = "Moras";
            this.btnMoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoras.UseVisualStyleBackColor = true;
            this.btnMoras.Click += new System.EventHandler(this.btnMoras_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 627);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(274, 45);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PrincipalLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 672);
            this.Controls.Add(this.btnBarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalLector";
            this.Text = "PrincipalLector";
            this.panel1.ResumeLayout(false);
            this.btnBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBuscarLibro.ResumeLayout(false);
            this.panelPagos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnBuscarlibro;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnMisPrestamos;
        private System.Windows.Forms.Panel panelBuscarLibro;
        private System.Windows.Forms.Button btnPorEditorial;
        private System.Windows.Forms.Button btnPorAutor;
        private System.Windows.Forms.Button btnPorCategoria;
        private System.Windows.Forms.Button btnPortitulo;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.Button btnHistorialPagos;
        private System.Windows.Forms.Button btnMoras;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}