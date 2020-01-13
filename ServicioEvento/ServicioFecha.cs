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
    public class ServicioFecha : IServicioFecha
    {
        private readonly IRecuperadorFechaEvento RecuperadorFecha;
        private string dtFormat = string.Empty;

        public ServicioFecha(IRecuperadorFechaEvento _RecuperadorFecha)
        {
            this.RecuperadorFecha = _RecuperadorFecha;
        }

        public List<Archivo> ObtenerDiferenciaFecha(List<Archivo> _lstArchivo)
        {
            return RecuperadorFecha.ObtenerDiferenciaFechas(_lstArchivo);
        }

        public List<Archivo> ObtenerValorDiferenciaFecha(List<Archivo> _lstArchivo)
        {
            return RecuperadorFecha.ObtenerValorDiferenciaFecha(_lstArchivo);
        }
    }
}
