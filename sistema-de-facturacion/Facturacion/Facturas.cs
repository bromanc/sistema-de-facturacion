﻿using System;
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
using sistema_de_facturacion.Huella;

namespace sistema_de_facturacion.Facturacion
{
    public partial class Facturas : Form
    {
        public Form inicial;
        Usuario vendedor;
        public String idCliente;
        public Facturas(Form interfazInicial, Usuario vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            this.inicial = interfazInicial;
            pagoBox.Enabled = false;
            productosField.Enabled = false;
            cantidadField.Enabled = false;
            button5.Enabled = false;
            quitarButton.Enabled = false;
            descuentoField.Enabled = false;
            calcularFButton.Enabled = false;
            confirmarFButton.Enabled = false;

        }
        public Facturas(Form interfazInicial, Cliente c, Factura f)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            citxt.Text = c.cRUC;
            nombretxt.Text = c.nombre;
            telefonotxt.Text = c.telefono;
            direcciontxt.Text = c.direccion;
            fechatx.Text = Convert.ToString(f.fecha);
            numeroFacturatxt.Text = Convert.ToString(f.codigo);
            vendedortxt.Text = f.vendedor;
            cargarPagos();
            consumidorButton.Enabled = false;
            parametroB.Enabled = false;
            parametroField.Enabled = false;
            huellaB.Enabled = false;
            pagoBox.SelectedValue = f.formaPago;
            subtotaltxt.Text = Convert.ToString(f.subTotal);
            descuentoField.Text = Convert.ToString(f.descuento);
            subnetotxt.Text = Convert.ToString(f.subTotalNeto);
            ivatxt.Text = Convert.ToString(f.iva);
            totaltxt.Text = Convert.ToString(f.total);
            confirmarFButton.Visible = false;
            button1.Visible = false;
            pagoBox.Enabled = false;
            productosField.Enabled = false;
            cantidadField.Enabled = false;
            button5.Enabled = false;
            quitarButton.Enabled = false;
            descuentoField.Enabled = false;
            calcularFButton.Enabled = false;
            confirmarFButton.Enabled = false;
            precompraGrid.DataSource = f.obtenerDetalle(f.codigo);
            precompraGrid.Enabled = false;
        }

        private void habilitoCampos()
        {
            cargarPagos();
            productosTabla();
            pagoBox.SelectedIndex = 0;
            ivatxt.Text = new ParametroM().obtenerIVA().iva.ToString();
            pagoBox.Enabled = true;
            productosField.Enabled = true;
            cantidadField.Enabled = true;
            button5.Enabled = true;
            quitarButton.Enabled = true;
            descuentoField.Enabled = true;
            calcularFButton.Enabled = true;
            confirmarFButton.Enabled = true;
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
            if (precompraGrid.Rows.Count > 0)
            {
                for (int i = 0; i < precompraGrid.Rows.Count; i++)
                {
                    string codigo = precompraGrid.Rows[i].Cells[1].Value.ToString();
                    int cantidad = Convert.ToInt32(precompraGrid.Rows[i].Cells[0].Value);
                    new DetalleFactura().quitarProductoPrecompra(codigo, cantidad);
                }

            }
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
            if (precompraGrid.Rows.Count > 0)
            {
                for (int i = 0; i < precompraGrid.Rows.Count; i++)
                {
                    string codigo = precompraGrid.Rows[i].Cells[1].Value.ToString();
                    int cantidad = Convert.ToInt32(precompraGrid.Rows[i].Cells[0].Value);
                    new DetalleFactura().quitarProductoPrecompra(codigo, cantidad);
                }
                
            }
            inicial.Visible = true;
            this.Visible = false;
        }

        private void TableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new AgregarCliente(this).Visible = true;
            this.Visible = false;
        }

        

        private void ParametroB_Click_1(object sender, EventArgs e)
        {
            if (parametroField.Text.Length > 0)
            {
                Cliente existente = new Cliente().obtenerCliente(parametroField.Text);
                if (existente == null)
                {
                    MessageBox.Show("Cliente no registrado en el sistema");
                }
                else
                {
                    habilitoCampos();
                    citxt.Text = existente.cRUC;
                    nombretxt.Text = existente.nombre;
                    telefonotxt.Text = existente.telefono;
                    direcciontxt.Text = existente.direccion;
                    DateTime fecha = DateTime.Now;
                    fechatx.Text = Convert.ToString(fecha);
                    numeroFacturatxt.Text = new Factura().maxIdFactura().ToString();
                    vendedortxt.Text = vendedor.nombres + " " + vendedor.apellidos; 

                }
            }
        }

        private void ConsumidorButton_Click(object sender, EventArgs e)
        {
            Cliente existente = new Cliente().obtenerCliente("999999999");
            habilitoCampos();
            citxt.Text = existente.cRUC;
            nombretxt.Text = existente.nombre;
            telefonotxt.Text = existente.telefono;
            direcciontxt.Text = existente.direccion;
            DateTime fecha = DateTime.Now;
            fechatx.Text = Convert.ToString(fecha);
            numeroFacturatxt.Text = new Factura().maxIdFactura().ToString();
            vendedortxt.Text = vendedor.nombres + " " + vendedor.apellidos;

            
        }

        private void ProductosField_KeyUp(object sender, KeyEventArgs e)
        {
            agregarGrid.DataSource = new Producto().buscarProductoVender(productosField.Text);
        }
        private void productosTabla()
        {
            agregarGrid.DataSource = new Producto().buscarProductoVender("");
        }
        //---------------------------ME QUEDÉ AQUÍ PROFORMA------------------------------//
        private void Button5_Click(object sender, EventArgs e)
        {
            


                if (agregarGrid.SelectedRows.Count > 0)
                {
                     if (String.IsNullOrEmpty(cantidadField.Text))
                     {
                    MessageBox.Show("Ingrese un número en el campo 'Cantidad'.");
                    }
                    else if (Convert.ToInt32(cantidadField.Text) <= 0 )
                    {
                        MessageBox.Show("Cantidad no válida, ingrese un número mayor que 0.");
                    }else if(Convert.ToInt32(cantidadField.Text.TrimEnd()) > Convert.ToInt32(agregarGrid.SelectedRows[0].Cells[3].Value))
                    {
                        MessageBox.Show("Cantidad insuficiente en stock");
                    }
                    else
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
                else
                {
                    MessageBox.Show("Seleccione al menos un producto a ser agregado.");
                }
            
        }
        private void calculosFactura()
        {
            Decimal subtotal = 0;
            Decimal descuento = 0;
            if (descuentoField.Text.Length > 0)
            {
               descuento = Convert.ToDecimal(descuentoField.Text);
            }
            for (int i = 0; i < precompraGrid.Rows.Count; i++)
            {
                subtotal = Convert.ToDecimal(precompraGrid.Rows[i].Cells[5].Value) + subtotal;
            }
            Decimal subtotalNeto = subtotal - ((subtotal * descuento) / 100);
            Decimal total = Math.Round((subtotalNeto + ((subtotalNeto * Convert.ToDecimal(ivatxt.Text)) / 100)),2);
            subtotaltxt.Text = subtotal.ToString();
            subnetotxt.Text = subtotalNeto.ToString();
            totaltxt.Text = total.ToString();

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
            else
            {
                MessageBox.Show("Seleccione al menos un producto para eliminarlo del detalle.");
            }
        }

        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcularFButton_Click(object sender, EventArgs e)
        {
            if (descuentoField.Text.Length > 0 && precompraGrid.Rows.Count>0)
            {
                if (Convert.ToDecimal(descuentoField.Text) > 15 )
                {
                    MessageBox.Show("Descuento global supera el 15%");
                }
                else if(Convert.ToDecimal(descuentoField.Text) < 0){
                    MessageBox.Show("Descuento debe ser mayor a 0%");
                }
                else {
                    calculosFactura();
                }
                
            }
            else
            {
                MessageBox.Show("No hay suficientes datos para calcular el valor de la factura.");
            }
            
        }

        private void ConfirmarFButton_Click(object sender, EventArgs e)
        {
            if (totaltxt.Text.Length > 0)
            {
                DateTime fecha = DateTime.Now;
                Factura factura = new Factura(0,citxt.Text,fecha,vendedortxt.Text, (String)pagoBox.SelectedValue,Convert.ToDecimal(subtotaltxt.Text),Convert.ToDecimal(descuentoField.Text),Convert.ToDecimal(subnetotxt.Text),Convert.ToDecimal(ivatxt.Text),Convert.ToDecimal(totaltxt.Text),1);
                int hecho = factura.agregarFactura(factura);
                if (hecho != -1)
                {
                    if(new DetalleFactura().insertarDetalleFactura() == 0)
                    {
                        MessageBox.Show("Factura generada con éxito");
                        inicial.Visible = true;
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen suficientes datos para generar la factura.");
            }
        }

        private void HuellaB_Click(object sender, EventArgs e)
        {
            new Huellas(this).Visible = true;
            this.Visible = false;
        }
        public void obtenerConHuella()
        {
            if (this.idCliente != null)
            {
                Cliente existente = new Cliente().obtenerCliente(this.idCliente);
                if (existente == null)
                {
                    MessageBox.Show("No se ha encontrado ningún cliente con esa identificación!");
                }
                else
                {
                    habilitoCampos();
                    citxt.Text = existente.cRUC;
                    nombretxt.Text = existente.nombre;
                    telefonotxt.Text = existente.telefono;
                    direcciontxt.Text = existente.direccion;
                    DateTime fecha = DateTime.Now;
                    fechatx.Text = Convert.ToString(fecha);
                    numeroFacturatxt.Text = new Factura().maxIdFactura().ToString();
                    vendedortxt.Text = vendedor.nombres + " " + vendedor.apellidos;

                }
            }

            
            
        }
    }
}
