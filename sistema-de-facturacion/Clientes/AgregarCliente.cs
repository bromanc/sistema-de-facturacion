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
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Clientes
{
    public partial class AgregarCliente : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificar;
        public String identificacion;
        Cliente modificarC= new Cliente();
        public AgregarCliente(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            nombreField.ReadOnly = true;
            apellidoField.ReadOnly = true;
            razonField.ReadOnly = true;
        }
        public AgregarCliente(Boolean modificacion, Form ventana, String identificacion)
        {
            InitializeComponent();
            this.modificar = modificacion;
            this.inicial = ventana;
            this.identificacion = identificacion;
            modificarF();

        }
        public void modificarF()
        {
            
            Cliente existente = modificarC.obtenerCliente(identificacion);
            cedulaRUCField.Text = existente.cRUC;
            if (existente.tipo.Equals('N'))
            {
                natural.Checked = true;
                razonField.Text = "";
                nombreField.Text = existente.nombre;
                apellidoField.Text = existente.apellido;
            }
            else
            {
                nombreField.Text = "";
                apellidoField.Text = "";
                juridica.Checked = true;
                razonField.Text = existente.nombre;
            }
            telefonoField.Text = existente.telefono;
            direccionField.Text = existente.direccion;
            correoField.Text = existente.correo;
            ciudadField.Text = existente.ciudad;
            if (existente.baja == 0)
            {
                inactivo.Checked = true;
            }
            else
            {
                activo.Checked = true;
            }
            huellaButton.Enabled = false;
            cedulaRUCField.ReadOnly = true;
            nombreField.ReadOnly = true;
            apellidoField.ReadOnly = true;
            razonField.ReadOnly = true;
            natural.Enabled = false;
            juridica.Enabled = false;
            activo.Enabled = false;
            inactivo.Enabled = false;
            labelIngreso.Text = "Modificación de Clientes";
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;

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
            if (natural.Checked)
            {
                fieldList.Add(nombreField);
                fieldList.Add(apellidoField);
            }
            if (juridica.Checked)
            {
                fieldList.Add(razonField);
            }
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            Boolean lleno = false;
            if(modificar == false)
            {
                //Registro cliente
                foreach (TextBox singleItem in fieldList)
                {
                    if (singleItem.Text.Equals(""))
                    {
                        lleno = true;
                        break;
                    }
                    
                }
                if (lleno || (!(natural.Checked) && !(juridica.Checked)) || (!(activo.Checked) && !(inactivo.Checked)))
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                }
                else
                {
                    Char tipo = 'V';
                    int estado = -1;
                    String nombre;
                    if (natural.Checked)
                    {
                         tipo = 'N';
                        nombre = nombreField.Text;
                    }
                    else
                    {
                         tipo = 'J';
                        nombre = razonField.Text;
                        apellidoField.Text = null;
                    }
                    if (activo.Checked)
                    {
                         estado = 1;
                    }
                    else
                    {
                         estado = 0;
                    }
                    //Verificar primero con regex antes de declarar el nuevo objeto cliente.
                    Cliente client = new Cliente(cedulaRUCField.Text,nombre,apellidoField.Text,telefonoField.Text,direccionField.Text,ciudadField.Text,correoField.Text,"STRING HUELLA5",tipo,estado);
                    int hecho = client.agregarCliente(client);
                    if (hecho == 0)
                    {
                        MessageBox.Show("Cliente registrado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    } else if (hecho == -1)
                    {
                        MessageBox.Show("El cliente especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al registrar el cliente.");
                    }
                    
                }
            }
            else
            {
                //Guardo cliente modificado
                
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
                    Cliente client = new Cliente(cedulaRUCField.Text, nombreField.Text, apellidoField.Text, telefonoField.Text, direccionField.Text, ciudadField.Text, correoField.Text, "STRING HUELLA5", 'M', 1);
                    if (client.modificarCliente(client) == 0)
                    {
                        MessageBox.Show("Cliente modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el cliente.");
                    }
                    
                    
                }
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            fieldList.Add(cedulaRUCField);
            if (natural.Checked)
            {
                fieldList.Add(nombreField);
                fieldList.Add(apellidoField);
            }
            if (juridica.Checked)
            {
                fieldList.Add(razonField);
            }
            fieldList.Add(telefonoField);
            fieldList.Add(direccionField);
            fieldList.Add(correoField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Text = "";
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juridica_CheckedChanged(object sender, EventArgs e)
        {
            nombreField.ReadOnly = true;
            apellidoField.ReadOnly = true;
            razonField.ReadOnly = false;
            razonField.Text = "";
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Natural_CheckedChanged(object sender, EventArgs e)
        {
            nombreField.ReadOnly = false;
            apellidoField.ReadOnly = false;
            razonField.ReadOnly = true;
            nombreField.Text = "";
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
