using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_de_facturacion.Principal;
namespace sistema_de_facturacion.Clientes
{
    public partial class AgregarCliente : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public AgregarCliente(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;

        }

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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(cedulaRUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            foreach(TextBox singleItem in fieldList) {
                if (singleItem.Text.Equals(""))
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                    break;
                }
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(cedulaRUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Text = "";
            }
        }
    }
}
