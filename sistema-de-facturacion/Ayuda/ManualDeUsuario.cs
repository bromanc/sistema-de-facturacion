﻿using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Ayuda
{
    public partial class ManualDeUsuario : Form
    {
        public Form inicial;
        public ManualDeUsuario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            axAcroPDF1.LoadFile("C:\\Users\\Ronny\\Documents\\Aplicaciones en Ambientes Propietarios\\Proyecto Ver. 2\\sistema-de-facturacion\\sistema-de-facturacion\\Resources\\UserManual.pdf");
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
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

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
    }
}