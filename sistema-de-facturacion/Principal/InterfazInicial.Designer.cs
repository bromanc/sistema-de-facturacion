namespace sistema_de_facturacion.Principal
{
    partial class InterfazInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazInicial));
            this.panelVertical = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.submenuProveedores = new System.Windows.Forms.Panel();
            this.submenuClientes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.eliminarProveedorButton = new System.Windows.Forms.Button();
            this.modificarProveedorButton = new System.Windows.Forms.Button();
            this.agregarProveedorButton = new System.Windows.Forms.Button();
            this.eliminarClienteButton = new System.Windows.Forms.Button();
            this.modificarClienteButton = new System.Windows.Forms.Button();
            this.agregarClienteButton = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.estadisticasButton = new System.Windows.Forms.Button();
            this.estimadosButton = new System.Windows.Forms.Button();
            this.proveedoresButton = new System.Windows.Forms.Button();
            this.clientesButton = new System.Windows.Forms.Button();
            this.facturacionButton = new System.Windows.Forms.Button();
            this.inventarioButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panelVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.submenuProveedores.SuspendLayout();
            this.submenuClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(63)))));
            this.panelVertical.Controls.Add(this.estadisticasButton);
            this.panelVertical.Controls.Add(this.estimadosButton);
            this.panelVertical.Controls.Add(this.proveedoresButton);
            this.panelVertical.Controls.Add(this.clientesButton);
            this.panelVertical.Controls.Add(this.facturacionButton);
            this.panelVertical.Controls.Add(this.inventarioButton);
            this.panelVertical.Controls.Add(this.pictureBox2);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 0);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(280, 650);
            this.panelVertical.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minimizar);
            this.panel2.Controls.Add(this.maximizar);
            this.panel2.Controls.Add(this.cerrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 50);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.panel1);
            this.contenedor.Controls.Add(this.submenuProveedores);
            this.contenedor.Controls.Add(this.submenuClientes);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(280, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1020, 600);
            this.contenedor.TabIndex = 2;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // submenuProveedores
            // 
            this.submenuProveedores.Controls.Add(this.eliminarProveedorButton);
            this.submenuProveedores.Controls.Add(this.modificarProveedorButton);
            this.submenuProveedores.Controls.Add(this.agregarProveedorButton);
            this.submenuProveedores.Location = new System.Drawing.Point(0, 260);
            this.submenuProveedores.Name = "submenuProveedores";
            this.submenuProveedores.Size = new System.Drawing.Size(273, 168);
            this.submenuProveedores.TabIndex = 1;
            this.submenuProveedores.Visible = false;
            // 
            // submenuClientes
            // 
            this.submenuClientes.Controls.Add(this.eliminarClienteButton);
            this.submenuClientes.Controls.Add(this.modificarClienteButton);
            this.submenuClientes.Controls.Add(this.agregarClienteButton);
            this.submenuClientes.Location = new System.Drawing.Point(310, 86);
            this.submenuClientes.Name = "submenuClientes";
            this.submenuClientes.Size = new System.Drawing.Size(273, 165);
            this.submenuClientes.TabIndex = 0;
            this.submenuClientes.Visible = false;
            this.submenuClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(338, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 227);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar Producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Editar Producto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nuevo Producto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // eliminarProveedorButton
            // 
            this.eliminarProveedorButton.FlatAppearance.BorderSize = 0;
            this.eliminarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProveedorButton.Image")));
            this.eliminarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProveedorButton.Location = new System.Drawing.Point(0, 113);
            this.eliminarProveedorButton.Name = "eliminarProveedorButton";
            this.eliminarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarProveedorButton.TabIndex = 4;
            this.eliminarProveedorButton.Text = "Eliminar Proveedor";
            this.eliminarProveedorButton.UseVisualStyleBackColor = true;
            // 
            // modificarProveedorButton
            // 
            this.modificarProveedorButton.FlatAppearance.BorderSize = 0;
            this.modificarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.modificarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarProveedorButton.Image")));
            this.modificarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarProveedorButton.Location = new System.Drawing.Point(-3, 58);
            this.modificarProveedorButton.Name = "modificarProveedorButton";
            this.modificarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.modificarProveedorButton.TabIndex = 4;
            this.modificarProveedorButton.Text = "Modificar Proveedor";
            this.modificarProveedorButton.UseVisualStyleBackColor = true;
            // 
            // agregarProveedorButton
            // 
            this.agregarProveedorButton.FlatAppearance.BorderSize = 0;
            this.agregarProveedorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.agregarProveedorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProveedorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProveedorButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.agregarProveedorButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarProveedorButton.Image")));
            this.agregarProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProveedorButton.Location = new System.Drawing.Point(3, 3);
            this.agregarProveedorButton.Name = "agregarProveedorButton";
            this.agregarProveedorButton.Size = new System.Drawing.Size(286, 52);
            this.agregarProveedorButton.TabIndex = 4;
            this.agregarProveedorButton.Text = "Agregar Proveedor";
            this.agregarProveedorButton.UseVisualStyleBackColor = true;
            this.agregarProveedorButton.Click += new System.EventHandler(this.Button11_Click);
            // 
            // eliminarClienteButton
            // 
            this.eliminarClienteButton.FlatAppearance.BorderSize = 0;
            this.eliminarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.eliminarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eliminarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarClienteButton.Image")));
            this.eliminarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarClienteButton.Location = new System.Drawing.Point(0, 113);
            this.eliminarClienteButton.Name = "eliminarClienteButton";
            this.eliminarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.eliminarClienteButton.TabIndex = 4;
            this.eliminarClienteButton.Text = "Eliminar Cliente";
            this.eliminarClienteButton.UseVisualStyleBackColor = true;
            this.eliminarClienteButton.Click += new System.EventHandler(this.Button9_Click);
            // 
            // modificarClienteButton
            // 
            this.modificarClienteButton.FlatAppearance.BorderSize = 0;
            this.modificarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.modificarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarClienteButton.Image")));
            this.modificarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarClienteButton.Location = new System.Drawing.Point(-3, 58);
            this.modificarClienteButton.Name = "modificarClienteButton";
            this.modificarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.modificarClienteButton.TabIndex = 4;
            this.modificarClienteButton.Text = "Modificar Cliente";
            this.modificarClienteButton.UseVisualStyleBackColor = true;
            this.modificarClienteButton.Click += new System.EventHandler(this.Button8_Click);
            // 
            // agregarClienteButton
            // 
            this.agregarClienteButton.FlatAppearance.BorderSize = 0;
            this.agregarClienteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.agregarClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarClienteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarClienteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.agregarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarClienteButton.Image")));
            this.agregarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarClienteButton.Location = new System.Drawing.Point(0, 3);
            this.agregarClienteButton.Name = "agregarClienteButton";
            this.agregarClienteButton.Size = new System.Drawing.Size(286, 52);
            this.agregarClienteButton.TabIndex = 4;
            this.agregarClienteButton.Text = "Agregar Cliente";
            this.agregarClienteButton.UseVisualStyleBackColor = true;
            this.agregarClienteButton.Click += new System.EventHandler(this.Button7_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(924, 9);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(24, 24);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(954, 9);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(24, 24);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 2;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(984, 9);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 24);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // estadisticasButton
            // 
            this.estadisticasButton.FlatAppearance.BorderSize = 0;
            this.estadisticasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.estadisticasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadisticasButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticasButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.estadisticasButton.Image = ((System.Drawing.Image)(resources.GetObject("estadisticasButton.Image")));
            this.estadisticasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadisticasButton.Location = new System.Drawing.Point(0, 423);
            this.estadisticasButton.Name = "estadisticasButton";
            this.estadisticasButton.Size = new System.Drawing.Size(280, 52);
            this.estadisticasButton.TabIndex = 3;
            this.estadisticasButton.Text = "Estadísticas";
            this.estadisticasButton.UseVisualStyleBackColor = true;
            this.estadisticasButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // estimadosButton
            // 
            this.estimadosButton.FlatAppearance.BorderSize = 0;
            this.estimadosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.estimadosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estimadosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimadosButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.estimadosButton.Image = ((System.Drawing.Image)(resources.GetObject("estimadosButton.Image")));
            this.estimadosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estimadosButton.Location = new System.Drawing.Point(0, 365);
            this.estimadosButton.Name = "estimadosButton";
            this.estimadosButton.Size = new System.Drawing.Size(280, 52);
            this.estimadosButton.TabIndex = 3;
            this.estimadosButton.Text = "Estimados";
            this.estimadosButton.UseVisualStyleBackColor = true;
            this.estimadosButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.FlatAppearance.BorderSize = 0;
            this.proveedoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.proveedoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedoresButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.proveedoresButton.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresButton.Image")));
            this.proveedoresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresButton.Location = new System.Drawing.Point(0, 307);
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.Size = new System.Drawing.Size(280, 52);
            this.proveedoresButton.TabIndex = 3;
            this.proveedoresButton.Text = "Proveedores";
            this.proveedoresButton.UseVisualStyleBackColor = true;
            this.proveedoresButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // clientesButton
            // 
            this.clientesButton.FlatAppearance.BorderSize = 0;
            this.clientesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.clientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clientesButton.Image = ((System.Drawing.Image)(resources.GetObject("clientesButton.Image")));
            this.clientesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesButton.Location = new System.Drawing.Point(0, 249);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(280, 52);
            this.clientesButton.TabIndex = 3;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // facturacionButton
            // 
            this.facturacionButton.FlatAppearance.BorderSize = 0;
            this.facturacionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.facturacionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturacionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.facturacionButton.Image = ((System.Drawing.Image)(resources.GetObject("facturacionButton.Image")));
            this.facturacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturacionButton.Location = new System.Drawing.Point(0, 191);
            this.facturacionButton.Name = "facturacionButton";
            this.facturacionButton.Size = new System.Drawing.Size(280, 52);
            this.facturacionButton.TabIndex = 3;
            this.facturacionButton.Text = "Facturación";
            this.facturacionButton.UseVisualStyleBackColor = true;
            this.facturacionButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // inventarioButton
            // 
            this.inventarioButton.FlatAppearance.BorderSize = 0;
            this.inventarioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.inventarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventarioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inventarioButton.Image = ((System.Drawing.Image)(resources.GetObject("inventarioButton.Image")));
            this.inventarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioButton.Location = new System.Drawing.Point(0, 133);
            this.inventarioButton.Name = "inventarioButton";
            this.inventarioButton.Size = new System.Drawing.Size(280, 52);
            this.inventarioButton.TabIndex = 2;
            this.inventarioButton.Text = "Inventario";
            this.inventarioButton.UseVisualStyleBackColor = true;
            this.inventarioButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Consultar Producto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // InterfazInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazInicial";
            this.Text = "InterazInicial";
            this.panelVertical.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.submenuProveedores.ResumeLayout(false);
            this.submenuClientes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button inventarioButton;
        private System.Windows.Forms.Button estadisticasButton;
        private System.Windows.Forms.Button estimadosButton;
        private System.Windows.Forms.Button proveedoresButton;
        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button facturacionButton;
        private System.Windows.Forms.Panel submenuClientes;
        private System.Windows.Forms.Button agregarClienteButton;
        private System.Windows.Forms.Button eliminarClienteButton;
        private System.Windows.Forms.Button modificarClienteButton;
        private System.Windows.Forms.Panel submenuProveedores;
        private System.Windows.Forms.Button eliminarProveedorButton;
        private System.Windows.Forms.Button modificarProveedorButton;
        private System.Windows.Forms.Button agregarProveedorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}