using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sistema_de_facturacion.Estimados
{
    public partial class VerProforma : Form
    {
        public Form inicial;
        public VerProforma(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public VerProforma(String modificar, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Revisar proforma seleccionada";
            labelIngreso.Text = "Revisión de Proformas";
            //verButton.Visible = false;
        }
        public VerProforma(Boolean anular, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.accionButton.Text = "Anular proforma seleccionada";
            labelIngreso.Text = "Anulación de Proforma";
            //verButton.Visible = false;
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }
    }
}
