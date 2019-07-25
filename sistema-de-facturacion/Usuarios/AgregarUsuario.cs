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
using sistema_de_facturacion.Modelo;

namespace sistema_de_facturacion.Usuarios
{
    public partial class AgregarUsuario : Form
    {
        public Form inicial;
        public List<TextBox> fieldList = new List<TextBox>();
        public Boolean rol, valido;
        public Boolean modificar;
        public Usuario obtenido = new Usuario();
        public Validacion validar = new Validacion();
        int VisibleTime = 3250;
        public AgregarUsuario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public AgregarUsuario(Usuario obtenido,Boolean modificacion, Form ventana)
        {
            InitializeComponent();
            this.modificar = modificacion;
            this.rol = true;
            this.obtenido = obtenido;
            this.inicial = ventana;
            modificarF();
        }
        public AgregarUsuario(Usuario obtenido, Form ventana)
        {
            InitializeComponent();
            this.inicial = ventana;
            this.obtenido = obtenido;
            this.modificar = true;
            modificarMis();
            
        }
        public void modificarMis()
        {
            usuarioBox.Enabled = false;
            huellaButton.Enabled = false;
            nombreField.ReadOnly = true;
            labelPassword.Text = "Nueva Contraseña:";
            registrarButton.Text = "Guardar Cambios";
            limpiarButton.Visible = false;
            labelIngreso.Text = "Modificación de Usuarios";
            establecerDatos();
        }
        public void establecerDatos()
        {
            nombreField.Text = obtenido.usuario;
            passwordField.Text = "";
            nombresField.Text = obtenido.nombres;
            if (obtenido.rol.Equals("Gerente"))
            {
                usuarioBox.SelectedIndex = 0;
            } else if (obtenido.rol.Equals("Vendedor"))
            {
                usuarioBox.SelectedIndex = 1;
            } else if (obtenido.rol.Equals("Bodeguero"))
            {
                usuarioBox.SelectedIndex = 2;
            }
            apellidoField.Text = obtenido.apellidos;
        }
        public void modificarF()
        {
            
            huellaButton.Enabled = false;
            nombreField.ReadOnly = true;
            registrarButton.Text = "Guardar Cambios";
            passwordField.ReadOnly = true;
            limpiarButton.Visible = false;
            nombresField.ReadOnly = true;
            labelIngreso.Text = "Modificación de Rol";
            establecerDatos();
            passwordField.Text = obtenido.contrasena;
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
            fieldList.Add(nombresField);
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
                   
                    Usuario user = new Usuario(nombreField.Text,passwordField.Text,nombresField.Text,apellidoField.Text,(String)usuarioBox.SelectedItem,"STRING HUELLAU");
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
                if (rol)
                {
                    obtenido.rol = (String)usuarioBox.SelectedItem;
                    if (obtenido.modificarRol(obtenido) == 0)
                    {
                        MessageBox.Show("Rol modificado exitosamente.");
                        inicial.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al modificar el rol.");
                    }
                }
                else
                {
                    
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
                        Usuario modificado = new Usuario(nombreField.Text, passwordField.Text,nombresField.Text,apellidoField.Text,(String)usuarioBox.SelectedItem, "HUELLA");
                        if (obtenido.modificarUsuario(modificado) == 0)
                        {
                            MessageBox.Show("Usuario modificado exitosamente.");
                            inicial.Visible = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al guardar los cambios.");
                        }
                    }
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
            fieldList.Add(nombresField);
            fieldList.Add(apellidoField);

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

        private void NombreField_KeyUp(object sender, KeyEventArgs e)
        {
            if (!validar.letras(nombreField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente letras.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void PasswordField_KeyUp(object sender, KeyEventArgs e)
        {
            if (!validar.letras(nombreField))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese únicamente números y letras.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void NombreField_Leave(object sender, EventArgs e)
        {
            if (nombreField.Text.Length > 12)
            {
                    ToolTip tt = new ToolTip();
                    tt.IsBalloon = true;
                    tt.Show("Ingrese un nombre de usuario de entre 8 y 12 caracteres.", nombreField, 0, -40, VisibleTime);
                
            }
            if (string.IsNullOrWhiteSpace(nombreField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", nombreField, 0, -40, VisibleTime);
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (nombreField.Text.Length > 15)
            {

                this.valido = false;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese un nombre de usuario de entre 8 y 15 caracteres.", nombreField, 0, -40, VisibleTime);

            }
            if (string.IsNullOrWhiteSpace(passwordField.Text))
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("No deje este campo vacío.", passwordField, 0, -40, VisibleTime);
            }
        }

        private void CorreoField_Leave(object sender, EventArgs e)
        {
            if (!validar.letras(nombresField))
            {
                this.valido = false;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.Show("Ingrese sólo letras", nombresField, 0, -40, VisibleTime);
            }
        }
    }
}
