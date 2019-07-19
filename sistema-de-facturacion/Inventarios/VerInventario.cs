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
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Inventarios
{
    public partial class VerInventario : Form
    {
        public Form inicial;
        public String tipo;
        public VerInventario(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            if (type.Equals("consultar"))
            {
                labelIngreso.Text = "Gestión de Productos";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de Productos";
                accionButton.Text = "Modificar datos del producto";
            }
            if (type.Equals("eliminar"))
            {

                labelIngreso.Text = "Eliminación de Productos";
                accionButton.Text = "Eliminar producto seleccionado";
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

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
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

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                productosGrid.DataSource = new Producto().buscarProducto(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                MessageBox.Show("Elija un parámetro.");
                parametroField.Clear();
            }
        }
    }
}