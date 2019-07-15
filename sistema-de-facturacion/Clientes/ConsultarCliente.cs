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

namespace sistema_de_facturacion.Clientes
{
    public partial class ConsultarCliente : Form
    {
        public Form inicial;
        public String tipo;
        Cliente buscar = new Cliente();
        public ConsultarCliente(String type,Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = type;
            clientesGrid.Update();
            clientesGrid.Refresh();
            if(type.Equals("consultar"))
            {
                labelIngreso.Text = "Consulta de Clientes";
                accionButton.Visible = false;
            }
            if (type.Equals("modificar"))
            {
                labelIngreso.Text = "Modificación de Clientes";
                accionButton.Text = "Modificar datos del cliente";
            }
            if (type.Equals("eliminar"))
            {

                labelIngreso.Text = "Eliminación de Clientes";
                accionButton.Text = "Eliminar cliente seleccionado";
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (clientesGrid.SelectedRows.Count > 0 && tipo.Equals("modificar")) 
            {
                string cedula = clientesGrid.SelectedRows[0].Cells[0].Value.ToString();
                new AgregarCliente(true, this,cedula).Visible = true;
                this.Visible = false;
            }
            if (clientesGrid.SelectedRows.Count > 0 && tipo.Equals("eliminar")) 
            {
                string cedula = clientesGrid.SelectedRows[0].Cells[0].Value.ToString();
                string estado = clientesGrid.SelectedRows[0].Cells[9].Value.ToString();
                MessageBox.Show(cedula+" ESTADO: "+estado);
                
                if (estado.Equals("1"))
                {
                    if (buscar.darDeBajaCliente(cedula)==0)
                    {
                        MessageBox.Show("Estado del cliente cambiado exitosamente.");
                        clientesGrid.Update();
                        clientesGrid.Refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del cliente.");
                    }
                }
                else
                {
                    if (buscar.darDeAltaCliente(cedula) == 0)
                    {
                        MessageBox.Show("Estado del cliente cambiado exitosamente.");
                        clientesGrid.Update();
                        clientesGrid.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado del cliente.");
                    }
                }
                
            }
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (parametroBox.Text.Length > 0)
            {
                clientesGrid.DataSource = buscar.buscarCliente(parametroBox.SelectedIndex, parametroField.Text);
            }
            else
            {
                MessageBox.Show("Elija un parámetro.");
                parametroField.Clear();
            }
        }

        private void ParametroField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
