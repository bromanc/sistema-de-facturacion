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

namespace sistema_de_facturacion.Inventarios
{
    public partial class VerInventario : Form
    {
        public Form inicial;
        public VerInventario(Form interfazInicial, int op)
        {

            InitializeComponent();
            this.inicial = interfazInicial;
            //op 1 consultar
            //op 2 editar
            //op 3 eliminar
            switch (op)
            {
                case 1:
                    btnGeneral.Text = "Consultar Producto";
                    break;

                case 2:
                    btnGeneral.Text = "Editar Producto";
                    break;

                case 3:
                    btnGeneral.Text = "Eliminar Producto";
                    break;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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
    }
}
