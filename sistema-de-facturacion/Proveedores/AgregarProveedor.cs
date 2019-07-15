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
    public partial class AgregarProveedor : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificacion;
        public String ruc;
        Proveedor modificar = new Proveedor();
        public AgregarProveedor(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public AgregarProveedor(Boolean modificar, Form interfaz, String ruc)
        {
            InitializeComponent();
            this.modificacion = modificar;
            labelIngreso.Text = "Registro de Proveedores";
            this.inicial = interfaz;
            this.ruc = ruc;
            modificarF();
        }
        public void modificarF()
        {
            Proveedor existente = modificar.obtenerProveedor(ruc);
            RUCField.Text = existente.ruc;
            nombreField.Text = existente.nombre;
            telefonoField.Text = existente.telefono;
            direccionField.Text = existente.direccion;
            ciudadField.Text = existente.ciudad;
            correoField.Text = existente.correo;
            contactoField.Text = existente.personaContacto;
            telefonoCField.Text = existente.numeroContacto;
            if (existente.baja == 1)
            {
                activo.Checked = true;
            }
            else
            {
                inactivo.Checked = true;
            }
            RUCField.ReadOnly = true;
            nombreField.ReadOnly = true;
            activo.Enabled = false;
            inactivo.Enabled = false;
            labelIngreso.Text = "Modificación de Proveedores";
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
            fieldList.Add(ciudadField);
            fieldList.Add(correoField);
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
                if (lleno || (!(activo.Checked) && !(inactivo.Checked)))
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    int estado = -1;
                    if (activo.Checked)
                    {
                        estado = 1;
                    }
                    else
                    {
                        estado = 0;
                    }
                    //Verificar primero con regex antes de declarar el nuevo objeto cliente.
                    Proveedor proveedor = new Proveedor(RUCField.Text, nombreField.Text, telefonoField.Text, direccionField.Text,ciudadField.Text, correoField.Text, contactoField.Text, telefonoCField.Text,estado);
                    int hecho = proveedor.agregarProveedor(proveedor);
                    if (hecho == 0)
                    {
                        MessageBox.Show("Proveedor registrado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else if (hecho == -1)
                    {
                        MessageBox.Show("El proveedor especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al registrar el proveedor.");

                    }
                    
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
                    Proveedor proveedor = new Proveedor(RUCField.Text,nombreField.Text,telefonoField.Text,direccionField.Text,ciudadField.Text, correoField.Text, contactoField.Text,telefonoCField.Text,1);
                    if (proveedor.modificarProveedor(proveedor) == 0)
                    {
                        MessageBox.Show("Proveedor modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el proveedor.");
                    }
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
            fieldList.Add(ciudadField);
            fieldList.Add(correoField);
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
