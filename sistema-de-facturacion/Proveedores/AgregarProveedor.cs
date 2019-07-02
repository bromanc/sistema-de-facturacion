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

namespace sistema_de_facturacion.Proveedores
{
    public partial class AgregarProveedor : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificacion;
        public AgregarProveedor(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public AgregarProveedor(Boolean modificar, Form interfaz)
        {
            InitializeComponent();
            this.modificacion = modificar;
            this.inicial = interfaz;
            modificarF();
        }
        public void modificarF()
        {
            RUCField.ReadOnly = true;
            nombreField.ReadOnly = true;
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
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

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(RUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            fieldList.Add(ciudadField);
            fieldList.Add(contactoField);
            fieldList.Add(telefonoCField);
            Boolean lleno = false;
            if (modificacion == false)
            {
                //Registro proveedor
                foreach (TextBox singleItem in fieldList)
                {
                    if (singleItem.Text.Equals(""))
                    {
                        lleno = true;
                        break;
                    }
                }
                if (lleno)
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    MessageBox.Show("Proveedor registrado exitosamente.");
                    inicial.Visible = true;
                    this.Close();
                }
            }
            else
            {
                //Guardo proveedor modificado

                foreach (TextBox singleItem in fieldList)
                {
                    
                        if (singleItem.Text.Equals(""))
                        {

                            lleno = true;
                            break;
                        }
                    
                    
                }
                if (lleno)
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    MessageBox.Show("Proveedor modificado exitosamente.");
                    inicial.Visible = true;
                    this.Close();
                }
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(RUCField);
            fieldList.Add(nombreField);
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            fieldList.Add(ciudadField);
            fieldList.Add(contactoField);
            fieldList.Add(telefonoCField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Text = "";
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
    }
}
