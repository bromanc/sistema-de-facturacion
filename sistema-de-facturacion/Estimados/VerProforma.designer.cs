﻿namespace sistema_de_facturacion.Estimados
{
    partial class VerProforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProforma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.parametroField = new System.Windows.Forms.TextBox();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.labelParametro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelElegir = new System.Windows.Forms.Label();
            this.parametroBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.accionButton = new System.Windows.Forms.Button();
            this.regresarButton = new System.Windows.Forms.Button();
            this.clientesGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.labelIngreso);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 50);
            this.panel1.TabIndex = 7;
            // 
            // labelIngreso
            // 
            this.labelIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreso.Location = new System.Drawing.Point(409, 16);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(164, 18);
            this.labelIngreso.TabIndex = 9;
            this.labelIngreso.Text = "Gestión de Proformas";
            this.labelIngreso.Click += new System.EventHandler(this.LabelIngreso_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(873, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(24, 24);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 5;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(903, 12);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(24, 24);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 4;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(933, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 24);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 3;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelParametro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 62);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.parametroField, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAdvertencia, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(232, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 56);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // parametroField
            // 
            this.parametroField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroField.Location = new System.Drawing.Point(3, 33);
            this.parametroField.Name = "parametroField";
            this.parametroField.ShortcutsEnabled = false;
            this.parametroField.Size = new System.Drawing.Size(469, 20);
            this.parametroField.TabIndex = 1;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.labelAdvertencia.Location = new System.Drawing.Point(98, 3);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(279, 21);
            this.labelAdvertencia.TabIndex = 2;
            this.labelAdvertencia.Text = "Debe elegir un parámetro primero!";
            // 
            // labelParametro
            // 
            this.labelParametro.AutoSize = true;
            this.labelParametro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelParametro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametro.Location = new System.Drawing.Point(3, 41);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(223, 21);
            this.labelParametro.TabIndex = 1;
            this.labelParametro.Text = "Ingrese el parámetro:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelElegir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.parametroBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(713, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 56);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelElegir
            // 
            this.labelElegir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelElegir.AutoSize = true;
            this.labelElegir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElegir.Location = new System.Drawing.Point(46, 0);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(161, 28);
            this.labelElegir.TabIndex = 0;
            this.labelElegir.Text = "Elegir el parámetro:";
            // 
            // parametroBox
            // 
            this.parametroBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parametroBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parametroBox.FormattingEnabled = true;
            this.parametroBox.Items.AddRange(new object[] {
            "Cédula de Identidad/RUC",
            "Nombre/Razón Social"});
            this.parametroBox.Location = new System.Drawing.Point(3, 31);
            this.parametroBox.Name = "parametroBox";
            this.parametroBox.Size = new System.Drawing.Size(248, 21);
            this.parametroBox.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.accionButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.regresarButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 492);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(970, 58);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // accionButton
            // 
            this.accionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accionButton.Location = new System.Drawing.Point(175, 3);
            this.accionButton.Name = "accionButton";
            this.accionButton.Size = new System.Drawing.Size(135, 52);
            this.accionButton.TabIndex = 2;
            this.accionButton.Text = "Revisar Proforma";
            this.accionButton.UseVisualStyleBackColor = true;
            // 
            // regresarButton
            // 
            this.regresarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regresarButton.Location = new System.Drawing.Point(660, 3);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(135, 52);
            this.regresarButton.TabIndex = 1;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // clientesGrid
            // 
            this.clientesGrid.AllowUserToAddRows = false;
            this.clientesGrid.AllowUserToDeleteRows = false;
            this.clientesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesGrid.Location = new System.Drawing.Point(0, 112);
            this.clientesGrid.Name = "clientesGrid";
            this.clientesGrid.ReadOnly = true;
            this.clientesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesGrid.Size = new System.Drawing.Size(970, 380);
            this.clientesGrid.TabIndex = 16;
            // 
            // VerProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 550);
            this.Controls.Add(this.clientesGrid);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerProforma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox parametroField;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.Label labelParametro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelElegir;
        private System.Windows.Forms.ComboBox parametroBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button accionButton;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.DataGridView clientesGrid;
    }
}