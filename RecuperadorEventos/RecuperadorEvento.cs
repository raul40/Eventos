using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioEventos;

namespace RecuperadorEventos
{
    public class RecuperadorEvento : IRecuperadorEvento
    {
        private readonly string cMensajeFechaFutura = "ocurrirá dentro de";
        private readonly string cMensajeFechaPasada = "ocurrió hace";

        public List<Archivo> ObtenerEventos(List<Archivo> _lstArchivo)
        {
            foreach (var item in _lstArchivo)
            {
                //if (item.dtFechaComparar > item.dtFechaEvento)
                if (item.iValorDiferencia >= 0)
                {
                    item.cMensajeEvento = string.Format("{0}, {1} {2} {3}", item.cNombreEvento, cMensajeFechaPasada, item.iValorDiferencia, item.cTipoFecha);
                }
                else
                {
                    item.cMensajeEvento = string.Format("{0}, {1} {2} {3}", item.cNombreEvento, cMensajeFechaFutura, item.iValorDiferencia, item.cTipoFecha);
                }

            }

            return _lstArchivo;
        }
    }
}
