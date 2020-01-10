using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos.Internaces
{
    public interface IRecuperadorFechaEvento
    {
        string cMensajeFechaFutura { get; set; }
        string cMensajeFechaPasada { get; set; }
        string ObtenerMensajeFecha(DateTime _dtFechaEvento, DateTime _dtFechaEvaluada);

        int ObtenerValorDiferenciaFecha(TimeSpan _tsDiferencia);

        string cTipoValorDiferenciaFecha(string _cTipoValorDiferencia, int _iDiferencia);
    }
}
