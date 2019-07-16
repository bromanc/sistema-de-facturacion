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
    public partial class Inventario : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Inventario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            cargarProveedores();
            cargarCategorias();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cargarProveedores()
        {
            Proveedor proveedor = new Proveedor();
            DataTable proveedores = proveedor.todoProveedor();
            proveedorBox.DisplayMember = "proveedorNombre".TrimEnd();
            proveedorBox.ValueMember = "proveedorNombre".TrimEnd();
            proveedorBox.DataSource = proveedores;
        }
        private void cargarCategorias()
        {
            Categoria categoria = new Categoria();
            DataTable categorias = categoria.todaCategoria();
            categoriaBox.DisplayMember = "categoriaNombre".TrimEnd();
            categoriaBox.ValueMember = "categoriaNombre".TrimEnd();
            categoriaBox.DataSource = categorias;
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime fecha = DateTime.Now;
                int idCategoria = new Categoria().obtenerIDCategoria(categoriaBox.Text);
                String rucProveedor = new Proveedor().obtenerRUCProveedor(proveedorBox.Text);
                Producto producto = new Producto(codigoField.Text, nombreField.Text, Convert.ToInt32(disponiblesField.Text), Convert.ToDecimal(unitarioField.Text), Convert.ToDecimal(descuentoField.Text), unidadField.Text, 0, Convert.ToDecimal(adquisicionField.Text), fecha, Convert.ToDecimal(gananciaField.Text), rucProveedor, 1, idCategoria, Convert.ToInt32(minimoField.Text));
                int hecho = producto.agregarProducto(producto);
                if (hecho == 0)
                {
                    MessageBox.Show("Producto registrado exitosamente.");
                    inicial.Visible = true;
                    this.Close();
                }
                else if (hecho == -1)
                {
                    MessageBox.Show("El producto especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Se produjo un error al registrar el producto.");
                }
            }
        }
        private Boolean validarCampos()
        {
            Boolean lleno = true;
            fieldList.Add(codigoField);
            fieldList.Add(nombreField);
            fieldList.Add(disponiblesField);
            fieldList.Add(unitarioField);
            fieldList.Add(descuentoField);
            fieldList.Add(adquisicionField);
            fieldList.Add(gananciaField);
            fieldList.Add(minimoField);
            if (!(proveedorBox.SelectedIndex > -1))
            {
                MessageBox.Show("Seleccione un proveedor.");
                return false;
            }
            if (!(categoriaBox.SelectedIndex > -1))
            {
                MessageBox.Show("Seleccione una categoría.");
                return false;
            }
            
                foreach (TextBox singleItem in fieldList)
                {
                    if (singleItem.Text.Equals(""))
                    {
                        lleno = false;
                        break;
                    }

                }
                if (lleno==false)
                {
                    MessageBox.Show("Llene todos los campos.");
                    return false;
                }
                
            
            return lleno;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
    }
}
