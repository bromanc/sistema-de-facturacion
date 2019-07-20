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

namespace sistema_de_facturacion.Proveedores
{
    public partial class ConsultarProveedor : Form
    {
        public Form inicial;
        public String tipo;
        Proveedor buscar = new Proveedor();
        public ConsultarProveedor(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            proveedorGrid.Update();
            proveedorGrid.Refresh();
            this.tipo = type;
            labelAdvertencia.Visible = false;
            if (type.Equals("consultar"))
            {
                labelIngreso.Text = "Consulta de Proveedores";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de Proveedores";
                accionButton.Text = "Modificar datos del proveedor";
            }
            if (type.Equals("eliminar"))
            {
                labelIngreso.Text = "Eliminación de Proveedores";
                accionButton.Text = "Eliminar proveedor seleccionado";
            }
        }

        private void ConsultarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void AccionButton_Click(object sender, EventArgs e)
        {
            if (proveedorGrid.SelectedRows.Count > 0 && tipo.Equals("modificar")) //Cambiar a 0.
            {
                //Obtengo el proveedor y despliego ventana con información.
                string ruc = proveedorGrid.SelectedRows[0].Cells[0].Value.ToString();
                new AgregarProveedor(true, this,ruc).Visible = true;
                this.Visible = false;
            }
            if (proveedorGrid.SelectedRows.Count > 0 && tipo.Equals("eliminar")) //Cambiar a 0.
            {
                string ruc = proveedorGrid.SelectedRows[0].Cells[0].Value.ToString();
                string estado = proveedorGrid.SelectedRows[0].Cells[8].Value.ToString();
                MessageBox.Show(ruc + " ESTADO: " + estado);

                if (estado.Equals("1"))
                {
                    if (buscar.darDeBajaProveedor(ruc) == 0)
                    {
                        MessageBox.Show("Estado del proveedor cambiado exitosamente.");
                        proveedorGrid.Update();
                        proveedorGrid.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del proveedor.");
                    }
                }
                else
                {
                    if (buscar.darDeAltaProveedor(ruc) == 0)
                    {
                        MessageBox.Show("Estado del proveedor cambiado exitosamente.");
                        proveedorGrid.Update();
                        proveedorGrid.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del proveedor.");
                    }
                }


            }
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ParametroField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParametroField_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void ParametroField_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                labelAdvertencia.Visible = false;
                proveedorGrid.DataSource = buscar.buscarProveedor(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                labelAdvertencia.Visible = true;
                parametroField.Clear();
            }
        }
    }
}
