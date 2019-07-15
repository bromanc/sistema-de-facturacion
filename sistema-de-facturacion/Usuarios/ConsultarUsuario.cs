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
    public partial class ConsultarUsuario : Form
    {
        public Form inicial;
        public String tipo;
        Usuario buscar = new Usuario();
        public ConsultarUsuario(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            if (type.Equals("consultar"))
            {
                labelIngreso.Text = "Consulta de Usuarios";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de usuarios";
                accionButton.Text = "Modificar datos del usuario";
            }
            if (type.Equals("eliminar"))
            {
                labelIngreso.Text = "Eliminación de Usuarios";
                accionButton.Text = "Eliminar usuario seleccionado";
            }
        }

        private void AccionV_Click(object sender, EventArgs e)
        {
            if (usuarioGrid.SelectedRows.Count > -1 && tipo.Equals("modificar")) //Cambiar a 0.
            {
                //Obtengo el usuario y despliego ventana con información.
                new AgregarUsuario(true, this).Visible = true;

                this.Visible = false;
            }
            if (usuarioGrid.SelectedRows.Count > -1 && tipo.Equals("eliminar")) //Cambiar a 0.
            {
                //Elimino el usuario seleccionado.
                string usuario = usuarioGrid.SelectedRows[0].Cells[0].Value.ToString();
                if (buscar.eliminarUsuario(usuario) == 0)
                {
                    MessageBox.Show("Usuario eliminado exitosamente.");
                    usuarioGrid.Update();
                    usuarioGrid.Refresh();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario eliminado.");
                }
            }
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

        private void Button2_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                usuarioGrid.DataSource = buscar.buscarUsuario(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                MessageBox.Show("Elija un parámetro.");
                parametroField.Clear();
            }
        }
    }
}
