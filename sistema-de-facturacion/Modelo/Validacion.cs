using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    class Validacion
    {
        public bool IsNaturalNumber(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("[$/&+,':;=?@#|]");
            return objNaturalPattern.IsMatch(campo.Text);
        }

    }
}
