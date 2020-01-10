using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorEventos.Interfaces
{
    public interface IValidadorFecha
    {
        DateTime ValidarFecha(string _cFecha);
    }
}
