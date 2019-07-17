using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Modelo
{
    class Factura
    {
        public String codigo { get; set; }
        public String rucCICliente { get; set; }
        public DateTime fecha { get; set; }
        public Decimal subTotal { get; set; }
        public Decimal descuento { get; set; }
        public Decimal subTotalNeto { get; set; }
        public Decimal iva    { get; set; }
        public Decimal total { get; set; }
        public int anulada { get; set; }
        ConexionDB conexion = new ConexionDB();
        public Factura(string codigo, string rucCICliente, DateTime fecha, decimal subTotal, decimal descuento, decimal subTotalNeto, decimal iva, decimal total, int anulada)
        {
            this.codigo = codigo;
            this.rucCICliente = rucCICliente;
            this.fecha = fecha;
            this.subTotal = subTotal;
            this.descuento = descuento;
            this.subTotalNeto = subTotalNeto;
            this.iva = iva;
            this.total = total;
            this.anulada = anulada;
        }

        public Factura()
        {
        }
        public int agregarFactura(Factura factura)
        {

            
            conexion.abrirConexion();
            SqlCommand cmd = new SqlCommand("uspRegistrarFactura", conexion.obtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@clienteRucCi", SqlDbType.VarChar).Value = factura.rucCICliente;
            cmd.Parameters.Add("@descuentoGlobal", SqlDbType.VarChar).Value = factura.descuento;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = factura.fecha;
            SqlParameter retval = cmd.Parameters.Add("@retorno", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int retorno = (int)cmd.Parameters["@retorno"].Value;
            conexion.cerrarConexion();
            return retorno;
        }
    }
}
