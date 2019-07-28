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
using sistema_de_facturacion.Clientes;
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Facturacion
{
    public partial class Facturas : Form
    {
        public Form inicial;
        Usuario vendedor;
        public Facturas(Form interfazInicial, Usuario vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            this.inicial = interfazInicial;
            productosTabla();
            cargarPagos();
        }
        private void cargarPagos()
        {
            DataTable pagos = new ParametroM().todoPago();
            pagoBox.DisplayMember = "tipoPago".TrimEnd();
            pagoBox.ValueMember = "tipoPago".TrimEnd();
            pagoBox.DataSource = pagos;
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

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Visible = false;
        }

        private void TableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new AgregarCliente(this).Visible = true;
        }

        

        private void ParametroB_Click_1(object sender, EventArgs e)
        {
            if (parametroField.Text.Length > 0)
            {
                Cliente existente = new Cliente().obtenerCliente(parametroField.Text);
                if (existente == null)
                {
                    MessageBox.Show("No se ha encontrado ningún cliente con esa identificación!");
                }
                else
                {
                    citxt.Text = existente.cRUC;
                    nombretxt.Text = existente.nombre;
                    telefonotxt.Text = existente.telefono;
                    direcciontxt.Text = existente.direccion;
                    DateTime fecha = DateTime.Now;
                    fechatx.Text = Convert.ToString(fecha);
                    numeroFacturatxt.Text = "0"; //Obtener max id
                    vendedortxt.Text = vendedor.nombres + " " + vendedor.apellidos; 

                }
            }
        }

        private void ConsumidorButton_Click(object sender, EventArgs e)
        {
            Cliente existente = new Cliente().obtenerCliente("999999999");
            if (existente == null)
            {
                MessageBox.Show("No se ha encontrado ningún cliente con esa identificación!");
            }
            else
            {
                citxt.Text = existente.cRUC;
                nombretxt.Text = existente.nombre;
                telefonotxt.Text = existente.telefono;
                direcciontxt.Text = existente.direccion;
                DateTime fecha = DateTime.Now;
                fechatx.Text = Convert.ToString(fecha);
                numeroFacturatxt.Text = "0"; //Obtener max id
                vendedortxt.Text = vendedor.nombres + " " + vendedor.apellidos;

            }
        }

        private void ProductosField_KeyUp(object sender, KeyEventArgs e)
        {
            agregarGrid.DataSource = new Producto().buscarProductoVender(productosField.Text);
        }
        private void productosTabla()
        {
            agregarGrid.DataSource = new Producto().buscarProductoVender("");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (agregarGrid.SelectedRows.Count > 0)
            {
                string codigo = agregarGrid.SelectedRows[0].Cells[0].Value.ToString();
                Producto obtenido = new Producto().obtenerProducto(codigo);
                DetalleFactura df = new DetalleFactura(Convert.ToInt32(numeroFacturatxt.Text), Convert.ToInt32(cantidadField.Text.TrimEnd()), obtenido.codigo, obtenido.nombre, obtenido.descuento, obtenido.precioVentaUnitario, Convert.ToDecimal(0.0));
                if (df.obtenerRegistroPrecompraFactura(codigo) == null)
                {
                    df.insertarProductoPrecompra(df);
                    precompraGrid.DataSource = df.todaPrecompra();
                    productosTabla();
                    productosField.Text = "";
                    cantidadField.Text = "";
                }
                else
                {
                    MessageBox.Show("El producto seleccionado ya se encuentra dentro del detalle.");
                }
            }
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            if(precompraGrid.SelectedRows.Count > 0)
            {
                string codigo = precompraGrid.SelectedRows[0].Cells[1].Value.ToString();
                int cantidad = Convert.ToInt32(precompraGrid.SelectedRows[0].Cells[0].Value);
                new DetalleFactura().quitarProductoPrecompra(codigo, cantidad);
                precompraGrid.DataSource = new DetalleFactura().todaPrecompra();
                productosTabla();
                productosField.Text = "";
                cantidadField.Text = "";
            }
        }
    }
}
