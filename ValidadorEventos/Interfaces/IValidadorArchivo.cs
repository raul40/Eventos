using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorEventos.Interfaces
{
    public interface IValidadorArchivo
    {
        bool ValidarExistenciaArchivo(string _cRuta);
    }
}
