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

namespace sistema_de_facturacion.Usuarios
{
    public partial class AgregarUsuario : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean modificar;
        public AgregarUsuario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public AgregarUsuario(Boolean modificacion, Form ventana)
        {
            InitializeComponent();
            this.modificar = modificacion;
            this.inicial = ventana;
            modificarF();

        }
        public void modificarF()
        {
            huellaButton.Enabled = false;
            nombreField.ReadOnly = true;
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
            labelIngreso.Text = "Modificación de Usuarios";
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {

            fieldList.Add(nombreField);
            fieldList.Add(passwordField);
            fieldList.Add(correoField);
            int selected = usuarioBox.SelectedIndex;
            Boolean lleno = false;
            if (modificar == false)
            {
                
                //Registro usuario
                foreach (TextBox singleItem in fieldList)
                {
                    if (selected.Equals(null))
                    {
                        lleno = true;
                        break;
                    }
                    if (singleItem.Text.Equals("") )
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
                    Usuario user = new Usuario(nombreField.Text,passwordField.Text,correoField.Text,selected,"STRING HUELLA5");
                    int hecho = user.agregarUsuario(user);
                    if (hecho == 0)
                    {
                        MessageBox.Show("Usuario registrado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else if (hecho == -1)
                    {
                        MessageBox.Show("El usuario especificado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al registrar el usuario.");
                    }
                }
            }
            else
            {
                //Guardo usuario modificado
                foreach (TextBox singleItem in fieldList)
                {
                    if (selected.Equals(null))
                    {
                        lleno = true;
                        break;
                    }
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
                    MessageBox.Show("Usuario modificado exitosamente.");
                    inicial.Visible = true;
                    this.Close();
                }
            }
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {

            fieldList.Add(nombreField);
            fieldList.Add(passwordField);
            fieldList.Add(correoField);
            foreach (TextBox singleItem in fieldList)
            {
                singleItem.Clear();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }
    }
}
