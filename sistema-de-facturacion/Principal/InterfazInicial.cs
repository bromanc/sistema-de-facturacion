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
using sistema_de_facturacion.Clientes;
using sistema_de_facturacion.Proveedores;
using sistema_de_facturacion.Usuarios;
using sistema_de_facturacion.Estadísticas;
using sistema_de_facturacion.Estimados;
using sistema_de_facturacion.Facturacion;
using sistema_de_facturacion.Inventarios;
using sistema_de_facturacion.Parámetros;

namespace sistema_de_facturacion.Principal
{
    public partial class InterfazInicial : Form
    {
        public Form inicial;
        public Boolean abierto = false;
        public InterfazInicial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
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
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
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
           
            new ConsultarCliente("modificar",this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
           
            new ConsultarCliente("eliminar",this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = true;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = true;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = true;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = true;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            new AgregarProveedor(this).Visible = true;
            submenuProveedores.Visible = false;
            this.Visible = false;
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            new ConsultarCliente("consultar",this).Visible = true;
            submenuClientes.Visible = false;
            this.Visible = false;
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            new ConsultarProveedor("consultar",this).Visible = true;
            submenuProveedores.Visible = false;
            this.Visible = false;
        }

        private void ModificarProveedorButton_Click(object sender, EventArgs e)
        {
            new ConsultarProveedor("modificar", this).Visible = true;
            submenuProveedores.Visible = false;
            this.Visible = false;
        }

        private void EliminarProveedorButton_Click(object sender, EventArgs e)
        {
            new ConsultarProveedor("eliminar", this).Visible = true;
            submenuProveedores.Visible = false;
            this.Visible = false;
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = true;
            submenuEstadisticas.Visible = false;
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
            new Parametro(this).Visible = true;
            this.Visible = false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            new AgregarUsuario(this).Visible = true;
            submenuUsuarios.Visible = false;
            this.Visible = false;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            new ConsultarUsuario("consultar",this).Visible = true;
            submenuUsuarios.Visible = false;
            this.Visible = false;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            new ConsultarUsuario("modificar", this).Visible = true;
            submenuUsuarios.Visible = false;
            this.Visible = false;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            new ConsultarUsuario("eliminar", this).Visible = true;
            submenuUsuarios.Visible = false;
            this.Visible = false;
        }

        private void VentasPeriodoButton_Click(object sender, EventArgs e)
        {
            new VentasPeriodo(this).Visible = true;
            submenuEstadisticas.Visible = false;
            this.Visible = false;
        }
        
         private void NuevaFacturaButton_Click(object sender, EventArgs e)
        {
        //    new Facturas(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void NuevaProformaButton_Click(object sender, EventArgs e)
        {
          // new Proforma(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;

        private void RevisarProformaButton_Click(object sender, EventArgs e)
        {
          //  new VerProforma(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void RevisarFacturaButton_Click(object sender, EventArgs e)
        {
           // new VerFactura(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;

        }
        private void AnularFacturaButton_Click(object sender, EventArgs e)
        {
          //  new VerFactura(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void NuevoProductoButton_Click(object sender, EventArgs e)
        {
        //    new Inventario(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }
        
         private void ConsultarProductoButton_Click(object sender, EventArgs e)
        {
          //  new VerInventario(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void EditarProductoButton_Click(object sender, EventArgs e)
        {
         //   new VerInventario(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
        //    new VerInventario(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void AnularProformaButton_Click(object sender, EventArgs e)
        {
        //    new VerProforma(this).Visible = true;
            submenuEstimados.Visible = false;
            this.Visible = false;
        }

        private void Lblhora_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void InventarioButton_MouseDown(object sender, MouseEventArgs e)
        {
            submenuInventario.Visible = true;
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void InventarioButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuInventario.Visible = true;
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void FacturacionButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = true;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void ClientesButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = true;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void ProveedoresButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = true;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void EstimadosButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = true;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void EstadisticasButton_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = true;
        }

        private void Button7_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = true;
            submenuEstadisticas.Visible = false;
        }

        private void Contenedor_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void Button8_MouseMove(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void Contenedor_MouseDown(object sender, MouseEventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void PanelVertical_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Contenedor_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void PanelVertical_Click(object sender, EventArgs e)
        {
            submenuClientes.Visible = false;
            submenuProveedores.Visible = false;
            submenuInventario.Visible = false;
            submenuEstimados.Visible = false;
            submenuFacturacion.Visible = false;
            submenuUsuarios.Visible = false;
            submenuEstadisticas.Visible = false;
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
