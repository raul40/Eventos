using RecuperadorEventos.Internaces;
using RepositorioEventos;
using ServicioEvento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioEvento
{
    public class ServicioArchivo : IServicioArchivo
    {
        private readonly IRecuperadorArchivo RecuperadorArchivo;

        public ServicioArchivo(IRecuperadorArchivo _RecuperadorArchivo)
        {
            this.RecuperadorArchivo = _RecuperadorArchivo;
        }

        public List<Archivo> ObtenerArchivo(string _cRutaArchivo)
        {
            List<Archivo> lstDatosArchivo = RecuperadorArchivo.ObtenerContenidoArchivo(_cRutaArchivo);
            return lstDatosArchivo;
        }
    }
}
