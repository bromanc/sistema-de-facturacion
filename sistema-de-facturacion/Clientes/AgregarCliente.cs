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
using System.Text.RegularExpressions;

namespace sistema_de_facturacion.Clientes
{
    public partial class AgregarCliente : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificar;
        public String identificacion;
        Validacion validar = new Validacion();
        Cliente modificarC= new Cliente();
        int VisibleTime = 3500;
        public AgregarCliente(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            razonField.Enabled = false;
            siRadio.Checked = true;
            natural.Checked = true;
            activo.Checked = true;


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
        public Boolean camposVacios()
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
            fieldList.Add(ciudadField);
            Boolean lleno = false;
            foreach (TextBox singleItem in fieldList)
            {
                if (singleItem.Text.Trim().Equals(""))
                {
                    lleno = true;
                    singleItem.BackColor = Color.Red;
                }
                else
                {
                    singleItem.BackColor = Color.White;
                }
            }
            return lleno;
        }
        private void RegistrarButton_Click(object sender, EventArgs e)
        {

            
            if (modificar == false)
            {
                //Registro cliente
                
                if (camposVacios())
                {
                    MessageBox.Show("Se requiere llenar todos los campos.");
                    fieldList.Clear();
                }
                else
                {
                    Char tipo = 'V';
                    int estado = -1;
                    String nombre, huella;
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
                    if (siRadio.Checked)
                    {
                        //Setear valor a huella
                    }
                    else
                    {
                        //huella = null
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
                
                
                if (camposVacios())
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
            if (juridica.Checked)
            {
                nombreField.BackColor = Color.White;
                apellidoField.BackColor = Color.White;
            }
            
            nombreField.Enabled = false;
            apellidoField.Enabled = false;
            razonField.Enabled = true;
            razonField.Text = "";
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Natural_CheckedChanged(object sender, EventArgs e)
        {
            if (natural.Checked)
            {
                razonField.BackColor = Color.White;
            }
            nombreField.Enabled = true;
            apellidoField.Enabled = true;
            razonField.Enabled = false;
            nombreField.Text = "";
            apellidoField.Text = "";
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

        private void NoRadio_CheckedChanged(object sender, EventArgs e)
        {
            huellaButton.Enabled = false;

        }

        private void SiRadio_CheckedChanged(object sender, EventArgs e)
        {
            huellaButton.Enabled = true;
        }

        private void CedulaRUCField_KeyUp(object sender, KeyEventArgs e)
        {
            cedulaRUCField.BackColor = Color.White;
            if (!validar.numeros(cedulaRUCField))
            {
                int VisibleTime = 4000;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente números.", cedulaRUCField, 0, -40, VisibleTime);
            }
        }

        private void NombreField_KeyUp(object sender, KeyEventArgs e)
        {
            nombreField.BackColor = Color.White;
            if (!validar.letras(nombreField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", nombreField, 0, -40, VisibleTime);
            }
            String sinEspacios = nombreField.Text;
            if ((nombreField.Text.Length - sinEspacios.Trim().Length) > 1)
            {

                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void ApellidoField_KeyUp(object sender, KeyEventArgs e)
        {
            apellidoField.BackColor = Color.White;
            if (!validar.letras(apellidoField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", apellidoField, 0, -40, VisibleTime);
            }
            String sinEspacios = apellidoField.Text;
            if ((apellidoField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", apellidoField, 0, -40, VisibleTime);
            }
        }

        private void RazonField_KeyUp(object sender, KeyEventArgs e)
        {
            razonField.BackColor = Color.White;
            if (!validar.letras(razonField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", razonField, 0, -40, VisibleTime);
            }
            String sinEspacios = razonField.Text;
            if ((razonField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", razonField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_KeyUp(object sender, KeyEventArgs e)
        {
            telefonoField.BackColor = Color.White;
            if (!validar.numeros(telefonoField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente números.", telefonoField, 0, -40, VisibleTime);
            }
        }

        private void DireccionField_KeyUp(object sender, KeyEventArgs e)
        {
            direccionField.BackColor = Color.White;
            if (!validar.letrasNumeros(direccionField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo letras y números.", direccionField, 0, -40, VisibleTime);
            }
            String sinEspacios = direccionField.Text;
            if ((direccionField.Text.Length - sinEspacios.Trim().Length) > 1)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo un espacio entre palabras.", direccionField, 0, -40, VisibleTime);
            }
        }

        private void CiudadField_KeyUp(object sender, KeyEventArgs e)
        {
            ciudadField.BackColor = Color.White;
            if (!validar.letras(ciudadField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", ciudadField, 0, -40, VisibleTime);
            }
            
        }

        private void CorreoField_Leave(object sender, EventArgs e)
        {
            correoField.BackColor = Color.White;
            if (!validar.correo(correoField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese un correo válido, ejemplo: persona@dominio.com", correoField, 0, -40, VisibleTime);
            }

        }

        private void NombreField_Leave(object sender, EventArgs e)
        {
            if (nombreField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(nombreField.Text.Substring(nombreField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", nombreField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void CiudadField_Leave(object sender, EventArgs e)
        {
            if (ciudadField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(ciudadField.Text.Substring(ciudadField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", ciudadField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", ciudadField, 0, -40, VisibleTime);
            }
        }

        private void ApellidoField_Leave(object sender, EventArgs e)
        {
            if (apellidoField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(apellidoField.Text.Substring(apellidoField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", apellidoField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", apellidoField, 0, -40, VisibleTime);
            }
        }

        private void RazonField_Leave(object sender, EventArgs e)
        {
            if (razonField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(razonField.Text.Substring(razonField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", razonField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", razonField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telefonoField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", telefonoField, 0, -40, VisibleTime);
            }
        }

        private void DireccionField_Leave(object sender, EventArgs e)
        {
            if (direccionField.Text.Length > 0)
            {
                if (string.IsNullOrWhiteSpace(direccionField.Text.Substring(direccionField.Text.Length - 1)))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje un espacio al final de la cadena.", direccionField, 0, -40, VisibleTime);
                }
            }
            else
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", direccionField, 0, -40, VisibleTime);
            }
        }

        private void TelefonoField_Enter(object sender, EventArgs e)
        {

        }

        private void CedulaRUCField_Leave(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(cedulaRUCField.Text))
                {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("No deje este campo vacío.", cedulaRUCField, 0, -40, VisibleTime);
                }
            
        }
    }
}
