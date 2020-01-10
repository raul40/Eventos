using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorEventos.Interfaces;

namespace ValidadorEventos
{
    public class ValidadorFecha : IValidadorFecha
    {
        private const string cFormatoFecha = "dd/MM/yyyy HH:mm";
        public DateTime ValidarFecha(string _cFecha)
        {
            DateTime dtFecha = DateTime.ParseExact(_cFecha, cFormatoFecha, CultureInfo.InvariantCulture);
            return dtFecha;
        }
    }
}
