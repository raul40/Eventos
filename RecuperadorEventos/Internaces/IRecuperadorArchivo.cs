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
        List<IArchivo> ObtenerContenidoArchivo(string _cRuta);

        List<IArchivo> ConvertirDatosArchivo(Array _arrDatos);
    }
}
