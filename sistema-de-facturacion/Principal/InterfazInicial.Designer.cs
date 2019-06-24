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
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelVertical.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelVertical.Controls.Add(this.button6);
            this.panelVertical.Controls.Add(this.button5);
            this.panelVertical.Controls.Add(this.button4);
            this.panelVertical.Controls.Add(this.button3);
            this.panelVertical.Controls.Add(this.button2);
            this.panelVertical.Controls.Add(this.button1);
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
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 600);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
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
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(280, 52);
            this.button6.TabIndex = 3;
            this.button6.Text = "Estadísticas";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 52);
            this.button5.TabIndex = 3;
            this.button5.Text = "Estimados";
            this.button5.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(0, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Proveedores";
            this.button4.UseVisualStyleBackColor = true;
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
            this.button3.Location = new System.Drawing.Point(0, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clientes";
            this.button3.UseVisualStyleBackColor = true;
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
            this.button2.Location = new System.Drawing.Point(0, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Facturación";
            this.button2.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inventario";
            this.button1.UseVisualStyleBackColor = true;
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
            // InterfazInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazInicial";
            this.Text = "InterazInicial";
            this.panelVertical.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}