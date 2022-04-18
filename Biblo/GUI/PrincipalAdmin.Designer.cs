namespace Biblo.GUI
{
    partial class PrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.btnVerCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.panelEditoriales = new System.Windows.Forms.Panel();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.btnGestionEditoriales = new System.Windows.Forms.Button();
            this.panelAutores = new System.Windows.Forms.Panel();
            this.btnListaAutores = new System.Windows.Forms.Button();
            this.btnAgregarAutores = new System.Windows.Forms.Button();
            this.btnGestionAutores = new System.Windows.Forms.Button();
            this.panelPagos = new System.Windows.Forms.Panel();
            this.btnVerMoras = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnGestionPagos = new System.Windows.Forms.Button();
            this.panelPrestamos = new System.Windows.Forms.Panel();
            this.btnVerprestamos = new System.Windows.Forms.Button();
            this.btnGestionPrestamos = new System.Windows.Forms.Button();
            this.panelLibros = new System.Windows.Forms.Panel();
            this.btnVerLibros = new System.Windows.Forms.Button();
            this.btnAgregarlibros = new System.Windows.Forms.Button();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.panelCuentas = new System.Windows.Forms.Panel();
            this.btnLectores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.btnGestionCuentas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.panelCategorias.SuspendLayout();
            this.panelEditoriales.SuspendLayout();
            this.panelAutores.SuspendLayout();
            this.panelPagos.SuspendLayout();
            this.panelPrestamos.SuspendLayout();
            this.panelLibros.SuspendLayout();
            this.panelCuentas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(99)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 403);
            this.panel1.TabIndex = 2;
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btnCerrarSesion);
            this.MenuVertical.Controls.Add(this.panelCategorias);
            this.MenuVertical.Controls.Add(this.btnCategorias);
            this.MenuVertical.Controls.Add(this.panelEditoriales);
            this.MenuVertical.Controls.Add(this.btnGestionEditoriales);
            this.MenuVertical.Controls.Add(this.panelAutores);
            this.MenuVertical.Controls.Add(this.btnGestionAutores);
            this.MenuVertical.Controls.Add(this.panelPagos);
            this.MenuVertical.Controls.Add(this.btnGestionPagos);
            this.MenuVertical.Controls.Add(this.panelPrestamos);
            this.MenuVertical.Controls.Add(this.btnGestionPrestamos);
            this.MenuVertical.Controls.Add(this.panelLibros);
            this.MenuVertical.Controls.Add(this.btnGestionLibros);
            this.MenuVertical.Controls.Add(this.panelCuentas);
            this.MenuVertical.Controls.Add(this.btnGestionCuentas);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 426);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 691);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(183, 29);
            this.btnCerrarSesion.TabIndex = 18;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // panelCategorias
            // 
            this.panelCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelCategorias.Controls.Add(this.btnVerCategoria);
            this.panelCategorias.Controls.Add(this.btnAgregarCategoria);
            this.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategorias.Location = new System.Drawing.Point(0, 634);
            this.panelCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(183, 57);
            this.panelCategorias.TabIndex = 15;
            // 
            // btnVerCategoria
            // 
            this.btnVerCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCategoria.FlatAppearance.BorderSize = 0;
            this.btnVerCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerCategoria.Location = new System.Drawing.Point(0, 26);
            this.btnVerCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerCategoria.Name = "btnVerCategoria";
            this.btnVerCategoria.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnVerCategoria.Size = new System.Drawing.Size(183, 26);
            this.btnVerCategoria.TabIndex = 1;
            this.btnVerCategoria.Text = "Ver categorías";
            this.btnVerCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCategoria.UseVisualStyleBackColor = true;
            this.btnVerCategoria.Click += new System.EventHandler(this.btnVerCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnAgregarCategoria.Size = new System.Drawing.Size(183, 26);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar categoría";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 605);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(183, 29);
            this.btnCategorias.TabIndex = 14;
            this.btnCategorias.Text = "Gestion de categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // panelEditoriales
            // 
            this.panelEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelEditoriales.Controls.Add(this.btnEditoriales);
            this.panelEditoriales.Controls.Add(this.btnAgregarEditorial);
            this.panelEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditoriales.Location = new System.Drawing.Point(0, 548);
            this.panelEditoriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEditoriales.Name = "panelEditoriales";
            this.panelEditoriales.Size = new System.Drawing.Size(183, 57);
            this.panelEditoriales.TabIndex = 13;
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditoriales.FlatAppearance.BorderSize = 0;
            this.btnEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoriales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoriales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditoriales.Location = new System.Drawing.Point(0, 26);
            this.btnEditoriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnEditoriales.Size = new System.Drawing.Size(183, 26);
            this.btnEditoriales.TabIndex = 1;
            this.btnEditoriales.Text = "Ver lista editoriales";
            this.btnEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditoriales.UseVisualStyleBackColor = true;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarEditorial.FlatAppearance.BorderSize = 0;
            this.btnAgregarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEditorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarEditorial.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnAgregarEditorial.Size = new System.Drawing.Size(183, 26);
            this.btnAgregarEditorial.TabIndex = 0;
            this.btnAgregarEditorial.Text = "Agregar editorial";
            this.btnAgregarEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEditorial.UseVisualStyleBackColor = true;
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
            // 
            // btnGestionEditoriales
            // 
            this.btnGestionEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEditoriales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionEditoriales.FlatAppearance.BorderSize = 0;
            this.btnGestionEditoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEditoriales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEditoriales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionEditoriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEditoriales.Location = new System.Drawing.Point(0, 519);
            this.btnGestionEditoriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionEditoriales.Name = "btnGestionEditoriales";
            this.btnGestionEditoriales.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionEditoriales.Size = new System.Drawing.Size(183, 29);
            this.btnGestionEditoriales.TabIndex = 12;
            this.btnGestionEditoriales.Text = "Gestion de editoriales";
            this.btnGestionEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEditoriales.UseVisualStyleBackColor = true;
            this.btnGestionEditoriales.Click += new System.EventHandler(this.btnGestionEditoriales_Click);
            // 
            // panelAutores
            // 
            this.panelAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelAutores.Controls.Add(this.btnListaAutores);
            this.panelAutores.Controls.Add(this.btnAgregarAutores);
            this.panelAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAutores.Location = new System.Drawing.Point(0, 462);
            this.panelAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAutores.Name = "panelAutores";
            this.panelAutores.Size = new System.Drawing.Size(183, 57);
            this.panelAutores.TabIndex = 11;
            // 
            // btnListaAutores
            // 
            this.btnListaAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaAutores.FlatAppearance.BorderSize = 0;
            this.btnListaAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAutores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAutores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaAutores.Location = new System.Drawing.Point(0, 26);
            this.btnListaAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListaAutores.Name = "btnListaAutores";
            this.btnListaAutores.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnListaAutores.Size = new System.Drawing.Size(183, 26);
            this.btnListaAutores.TabIndex = 1;
            this.btnListaAutores.Text = "Ver lista autores";
            this.btnListaAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaAutores.UseVisualStyleBackColor = true;
            this.btnListaAutores.Click += new System.EventHandler(this.btnListaAutores_Click);
            // 
            // btnAgregarAutores
            // 
            this.btnAgregarAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarAutores.FlatAppearance.BorderSize = 0;
            this.btnAgregarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAutores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarAutores.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarAutores.Name = "btnAgregarAutores";
            this.btnAgregarAutores.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnAgregarAutores.Size = new System.Drawing.Size(183, 26);
            this.btnAgregarAutores.TabIndex = 0;
            this.btnAgregarAutores.Text = "Agregar autores";
            this.btnAgregarAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAutores.UseVisualStyleBackColor = true;
            this.btnAgregarAutores.Click += new System.EventHandler(this.btnAgregarAutores_Click);
            // 
            // btnGestionAutores
            // 
            this.btnGestionAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionAutores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionAutores.FlatAppearance.BorderSize = 0;
            this.btnGestionAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAutores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAutores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAutores.Location = new System.Drawing.Point(0, 433);
            this.btnGestionAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionAutores.Name = "btnGestionAutores";
            this.btnGestionAutores.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionAutores.Size = new System.Drawing.Size(183, 29);
            this.btnGestionAutores.TabIndex = 10;
            this.btnGestionAutores.Text = "Gestion de autores";
            this.btnGestionAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAutores.UseVisualStyleBackColor = true;
            this.btnGestionAutores.Click += new System.EventHandler(this.btnGestionAutores_Click);
            // 
            // panelPagos
            // 
            this.panelPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelPagos.Controls.Add(this.btnVerMoras);
            this.panelPagos.Controls.Add(this.btnRegistrarPago);
            this.panelPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPagos.Location = new System.Drawing.Point(0, 376);
            this.panelPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(183, 57);
            this.panelPagos.TabIndex = 9;
            // 
            // btnVerMoras
            // 
            this.btnVerMoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerMoras.FlatAppearance.BorderSize = 0;
            this.btnVerMoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMoras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerMoras.Location = new System.Drawing.Point(0, 26);
            this.btnVerMoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerMoras.Name = "btnVerMoras";
            this.btnVerMoras.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnVerMoras.Size = new System.Drawing.Size(183, 26);
            this.btnVerMoras.TabIndex = 1;
            this.btnVerMoras.Text = "Ver moras";
            this.btnVerMoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMoras.UseVisualStyleBackColor = true;
            this.btnVerMoras.Click += new System.EventHandler(this.btnVerMoras_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarPago.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnRegistrarPago.Size = new System.Drawing.Size(183, 26);
            this.btnRegistrarPago.TabIndex = 0;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // btnGestionPagos
            // 
            this.btnGestionPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPagos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPagos.FlatAppearance.BorderSize = 0;
            this.btnGestionPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPagos.Location = new System.Drawing.Point(0, 347);
            this.btnGestionPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionPagos.Name = "btnGestionPagos";
            this.btnGestionPagos.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionPagos.Size = new System.Drawing.Size(183, 29);
            this.btnGestionPagos.TabIndex = 8;
            this.btnGestionPagos.Text = "Gestion de pagos";
            this.btnGestionPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPagos.UseVisualStyleBackColor = true;
            this.btnGestionPagos.Click += new System.EventHandler(this.btnGestionPagos_Click);
            // 
            // panelPrestamos
            // 
            this.panelPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelPrestamos.Controls.Add(this.btnVerprestamos);
            this.panelPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrestamos.Location = new System.Drawing.Point(0, 313);
            this.panelPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrestamos.Name = "panelPrestamos";
            this.panelPrestamos.Size = new System.Drawing.Size(183, 34);
            this.panelPrestamos.TabIndex = 7;
            // 
            // btnVerprestamos
            // 
            this.btnVerprestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerprestamos.FlatAppearance.BorderSize = 0;
            this.btnVerprestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerprestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerprestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerprestamos.Location = new System.Drawing.Point(0, 0);
            this.btnVerprestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerprestamos.Name = "btnVerprestamos";
            this.btnVerprestamos.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnVerprestamos.Size = new System.Drawing.Size(183, 26);
            this.btnVerprestamos.TabIndex = 0;
            this.btnVerprestamos.Text = "Ver préstamos";
            this.btnVerprestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerprestamos.UseVisualStyleBackColor = true;
            this.btnVerprestamos.Click += new System.EventHandler(this.btnVerprestamos_Click);
            // 
            // btnGestionPrestamos
            // 
            this.btnGestionPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            this.btnGestionPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPrestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPrestamos.Location = new System.Drawing.Point(0, 284);
            this.btnGestionPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionPrestamos.Name = "btnGestionPrestamos";
            this.btnGestionPrestamos.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionPrestamos.Size = new System.Drawing.Size(183, 29);
            this.btnGestionPrestamos.TabIndex = 6;
            this.btnGestionPrestamos.Text = "Gestion de préstamos";
            this.btnGestionPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPrestamos.UseVisualStyleBackColor = true;
            this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);
            // 
            // panelLibros
            // 
            this.panelLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelLibros.Controls.Add(this.btnVerLibros);
            this.panelLibros.Controls.Add(this.btnAgregarlibros);
            this.panelLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibros.Location = new System.Drawing.Point(0, 227);
            this.panelLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Size = new System.Drawing.Size(183, 57);
            this.panelLibros.TabIndex = 5;
            // 
            // btnVerLibros
            // 
            this.btnVerLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerLibros.FlatAppearance.BorderSize = 0;
            this.btnVerLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLibros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerLibros.Location = new System.Drawing.Point(0, 26);
            this.btnVerLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerLibros.Name = "btnVerLibros";
            this.btnVerLibros.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnVerLibros.Size = new System.Drawing.Size(183, 26);
            this.btnVerLibros.TabIndex = 1;
            this.btnVerLibros.Text = "Ver libros";
            this.btnVerLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerLibros.UseVisualStyleBackColor = true;
            this.btnVerLibros.Click += new System.EventHandler(this.btnVerLibros_Click);
            // 
            // btnAgregarlibros
            // 
            this.btnAgregarlibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarlibros.FlatAppearance.BorderSize = 0;
            this.btnAgregarlibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarlibros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarlibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarlibros.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarlibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarlibros.Name = "btnAgregarlibros";
            this.btnAgregarlibros.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnAgregarlibros.Size = new System.Drawing.Size(183, 26);
            this.btnAgregarlibros.TabIndex = 0;
            this.btnAgregarlibros.Text = "Agregar libros";
            this.btnAgregarlibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarlibros.UseVisualStyleBackColor = true;
            this.btnAgregarlibros.Click += new System.EventHandler(this.btnAgregarlibros_Click_1);
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionLibros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionLibros.FlatAppearance.BorderSize = 0;
            this.btnGestionLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLibros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionLibros.Location = new System.Drawing.Point(0, 198);
            this.btnGestionLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionLibros.Size = new System.Drawing.Size(183, 29);
            this.btnGestionLibros.TabIndex = 4;
            this.btnGestionLibros.Text = "Gestion de libros";
            this.btnGestionLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionLibros.UseVisualStyleBackColor = true;
            this.btnGestionLibros.Click += new System.EventHandler(this.btnGestionLibros_Click);
            // 
            // panelCuentas
            // 
            this.panelCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelCuentas.Controls.Add(this.btnLectores);
            this.panelCuentas.Controls.Add(this.btnEmpleados);
            this.panelCuentas.Controls.Add(this.btnMiPerfil);
            this.panelCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCuentas.Location = new System.Drawing.Point(0, 115);
            this.panelCuentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCuentas.Name = "panelCuentas";
            this.panelCuentas.Size = new System.Drawing.Size(183, 83);
            this.panelCuentas.TabIndex = 3;
            // 
            // btnLectores
            // 
            this.btnLectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLectores.FlatAppearance.BorderSize = 0;
            this.btnLectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLectores.Location = new System.Drawing.Point(0, 52);
            this.btnLectores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLectores.Name = "btnLectores";
            this.btnLectores.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnLectores.Size = new System.Drawing.Size(183, 26);
            this.btnLectores.TabIndex = 2;
            this.btnLectores.Text = "Lectores";
            this.btnLectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectores.UseVisualStyleBackColor = true;
            this.btnLectores.Click += new System.EventHandler(this.btnLectores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 26);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(183, 26);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiPerfil.FlatAppearance.BorderSize = 0;
            this.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMiPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnMiPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.btnMiPerfil.Size = new System.Drawing.Size(183, 26);
            this.btnMiPerfil.TabIndex = 0;
            this.btnMiPerfil.Text = "Mi perfil";
            this.btnMiPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiPerfil.UseVisualStyleBackColor = true;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // btnGestionCuentas
            // 
            this.btnGestionCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCuentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionCuentas.FlatAppearance.BorderSize = 0;
            this.btnGestionCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(51)))));
            this.btnGestionCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCuentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCuentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCuentas.Location = new System.Drawing.Point(0, 86);
            this.btnGestionCuentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionCuentas.Name = "btnGestionCuentas";
            this.btnGestionCuentas.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGestionCuentas.Size = new System.Drawing.Size(183, 29);
            this.btnGestionCuentas.TabIndex = 2;
            this.btnGestionCuentas.Text = "Gestion de cuentas";
            this.btnGestionCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCuentas.UseVisualStyleBackColor = true;
            this.btnGestionCuentas.Click += new System.EventHandler(this.btnGestionCuentas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 86);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(575, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(17, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(555, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(17, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(534, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(555, 2);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(17, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnSalir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(600, 23);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrincipalAdmin";
            this.Text = "PrincipalAdmin";
            this.MenuVertical.ResumeLayout(false);
            this.panelCategorias.ResumeLayout(false);
            this.panelEditoriales.ResumeLayout(false);
            this.panelAutores.ResumeLayout(false);
            this.panelPagos.ResumeLayout(false);
            this.panelPrestamos.ResumeLayout(false);
            this.panelLibros.ResumeLayout(false);
            this.panelCuentas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCuentas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnGestionCuentas;
        private System.Windows.Forms.Panel panelLibros;
        private System.Windows.Forms.Button btnVerLibros;
        private System.Windows.Forms.Button btnAgregarlibros;
        private System.Windows.Forms.Button btnGestionLibros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Panel panelEditoriales;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Button btnGestionEditoriales;
        private System.Windows.Forms.Panel panelAutores;
        private System.Windows.Forms.Button btnListaAutores;
        private System.Windows.Forms.Button btnAgregarAutores;
        private System.Windows.Forms.Button btnGestionAutores;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.Button btnVerMoras;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnGestionPagos;
        private System.Windows.Forms.Panel panelPrestamos;
        private System.Windows.Forms.Button btnVerprestamos;
        private System.Windows.Forms.Button btnGestionPrestamos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Button btnVerCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnLectores;
    }
}