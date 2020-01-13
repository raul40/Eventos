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
    public class ServicioTipoFecha : IServicioTipoFecha
    {
        private readonly IRecuperadorTipoFecha RecuperadorTipoFecha;

        public ServicioTipoFecha(IRecuperadorTipoFecha _RecuperadorTipoFecha)
        {
            this.RecuperadorTipoFecha = _RecuperadorTipoFecha;
        }

        public List<Archivo> ObtenerTipoFecha(List<Archivo> lstArchivos)
        {
            return RecuperadorTipoFecha.ObtenerTiposFecha(lstArchivos);
        }
    }
}
