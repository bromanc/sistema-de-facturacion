using sistema_de_facturacion.Modelo;
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
        Categoria buscar = new Categoria();
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
                string nombre = categoriasGrid.SelectedRows[0].Cells[1].Value.ToString();
                Categoria obtenida = buscar.obtenerCategoria(nombre);
                new AgregarCategoria(true, this, obtenida).Visible = true;
                this.Visible = false;
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }

        private void ParametroField_KeyPress(object sender, KeyPressEventArgs e)
        {
            categoriasGrid.DataSource = buscar.buscarCategoria(parametroField.Text.TrimEnd());
        }
    }
}
