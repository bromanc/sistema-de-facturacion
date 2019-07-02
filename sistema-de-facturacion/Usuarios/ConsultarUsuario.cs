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

namespace sistema_de_facturacion.Usuarios
{
    public partial class ConsultarUsuario : Form
    {
        public Form inicial;
        public String tipo;
        public ConsultarUsuario(String type, Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            if (type.Equals("consultar"))
            {
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                accionButton.Text = "Modificar datos del usuario";
            }
            if (type.Equals("eliminar"))
            {
                accionButton.Text = "Eliminar usuario seleccionado";
            }
        }

        private void AccionV_Click(object sender, EventArgs e)
        {
            if (usuariosGrid.SelectedRows.Count > -1 && tipo.Equals("modificar")) //Cambiar a 0.
            {
                //Obtengo el usuario y despliego ventana con información.
                new AgregarUsuario(true, this).Visible = true;

                this.Visible = false;
            }
            if (usuariosGrid.SelectedRows.Count > -1 && tipo.Equals("eliminar")) //Cambiar a 0.
            {
                //Elimino el usuario seleccionado.

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
    }
}
