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
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Parámetros
{
    public partial class Parametro : Form
    {
        public Form inicial;
        ParametroM IVA = new ParametroM();
        public Parametro(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            establecerIVA();

        }
        private void establecerIVA()
        {
            ParametroM iva = IVA.obtenerIVA();
            ivaField.Text = Convert.ToString(iva.iva);
        }
        private void Parametro_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
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

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void GuardarB_Click(object sender, EventArgs e)
        {
            if (ivaField.Text.Length > 0)
            {
                ParametroM nuevo = new ParametroM(Convert.ToDecimal(ivaField.Text), 1);
                if (IVA.modificarIVA(nuevo) == 0)
                {
                    MessageBox.Show("Cambios guardados.");
                    this.Visible = false;
                    inicial.Visible = true;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al guardar los cambios.");
                }

            }
        }
    }
}
