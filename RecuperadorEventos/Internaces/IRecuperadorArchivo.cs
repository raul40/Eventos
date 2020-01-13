using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos.Internaces
{
    public interface IRecuperadorArchivo
    {
        List<Archivo> ObtenerContenidoArchivo(string _cRuta);

    }
}
