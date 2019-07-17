using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Modelo
{
    class DetalleFactura
    {
        public int codigoFactura { get; set; }
        public String codigoProducto { get; set; }
        public int cantidad { get; set; }
        public Decimal descuento { get; set; }
        public Decimal valorUnitario { get; set; }
        public Decimal valorTotal { get; set; }

        public DetalleFactura(int codigoFactura, string codigoProducto, int cantidad, decimal descuento, decimal valorUnitario, decimal valorTotal)
        {
            this.codigoFactura = codigoFactura;
            this.codigoProducto = codigoProducto;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;
        }

        public DetalleFactura()
        {
        }
    }
}
