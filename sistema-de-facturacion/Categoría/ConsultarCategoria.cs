using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Categoría
{
    public partial class ConsultarCategoria : Form
    {
        public Form inicial;
        String tipo;
        public ConsultarCategoria(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }
        public ConsultarCategoria(Form interfazInicial, String tipo)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
            this.tipo = tipo;
        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
            new AgregarCategoria(this).Visible = true;
            this.Visible = false;
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            if (categoriasGrid.SelectedRows.Count > 0)
            {
                
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
    }
}
