using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    public class Validacion
    {
        private const string Pattern = "^[\\p{L}\\p{M}\\p{Zs}]+$";
        //private const string Pattern = "^[a-zA-Z]+$"; "^[0-9$&+,':;=?@#|]+$"
        public Validacion()
        {

        }
        public bool caracteres(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("[$/&+!,':;=?@#|]");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letras(TextBox campo)
        {
            Regex objNaturalPattern = new Regex(Pattern);
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letrasEspacio(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^([\\p{L}\\p{M}]+[\\p{Zs}]{0,1}[\\p{L}\\p{M}]*)+$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool correo(TextBox campo)
        {

            Regex objNaturalPattern = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool numeros(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^[0-9]*$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letrasNumeros(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^[\\p{L}\\p{M}\\d\\p{Zs}.-]+$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
    }
}
