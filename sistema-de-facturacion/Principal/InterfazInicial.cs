﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_de_facturacion.Clientes;
namespace sistema_de_facturacion.Principal
{
    public partial class InterfazInicial : Form
    {
        public Form inicial;
        public Boolean abierto = false;
        public InterfazInicial()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (panelVertical.Width == 280)
            {
                panelVertical.Width = 85;
            }
            else
            {
                panelVertical.Width = 280;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = true;
            submenuProveedores.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new AgregarCliente(this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
            

        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
            abierto = true;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
           
            new ModificarCliente(this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
           
            new EliminarCliente(this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            submenuProveedores.Visible = false;
            submenuClientes.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }
    }
}
