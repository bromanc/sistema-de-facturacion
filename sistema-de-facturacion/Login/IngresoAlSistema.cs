﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_de_facturacion.Principal;
using System.Windows.Forms;

namespace sistema_de_facturacion.Login
{
    public partial class IngresoAlSistema : Form
    {
        public List<TextBox> fieldList = new List<TextBox>();
        public Form principal = new InterfazInicial();
        public IngresoAlSistema()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ingresarSistema();
        }
        private void ingresarSistema()
        {
            fieldList.Add(usuarioField);
            fieldList.Add(passwordField);
            Boolean lleno = false;
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
                if (usuarioField.Text.Equals("JordyGarofalo") && passwordField.Text.Equals("surtiraderas"))
                {
                    principal.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }
        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingresarSistema();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
