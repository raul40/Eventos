using RecuperadorEventos.Internaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos
{
    public class RecuperadorFechaEvento : IRecuperadorFechaEvento
    {
        private readonly string cMensajeFechaFutura = "ocurrirá dentro de";
        private readonly string cMensajeFechaPasada = "ocurrió hace";
        public string ObtenerMensajeFecha(DateTime _dtFechaEvento, DateTime _dtFechaEvaluada)
        {
            string cMensajeFecha = string.Empty;
            TimeSpan tsDiferencia;
            string cTexto = string.Empty;
            string cTextoTiempo = string.Empty;
            string cTextoFechaEvento = string.Empty;

            if (_dtFechaEvaluada >= _dtFechaEvento)
            {
                tsDiferencia = _dtFechaEvaluada - _dtFechaEvento;
                cTexto = cMensajeFechaPasada;
            }
            else
            {
                tsDiferencia = _dtFechaEvento - _dtFechaEvaluada;
                cTexto = cMensajeFechaFutura;
            }

            ObtenerValorDiferenciaFecha(tsDiferencia);

            return cMensajeFecha;
        }

        public int ObtenerValorDiferenciaFecha(TimeSpan _tsDiferencia)
        {
            int iValorDiferenciaFecha = 0;
            string cTiempo = string.Empty;
            string ctipoValorDiferencia = string.Empty;
            int iDiferencia = 0;

            if (_tsDiferencia.Days > 31)
            {
                iDiferencia = _tsDiferencia.Days / 31;
                ctipoValorDiferencia = "MES";
            }
            else if (_tsDiferencia.Days > 0)
            {
                iDiferencia = _tsDiferencia.Days;
                ctipoValorDiferencia = "DIA";
            }
            else if (_tsDiferencia.Hours > 0)
            {
                iDiferencia = _tsDiferencia.Hours;
                ctipoValorDiferencia = "HORAS";
            }
            else if (_tsDiferencia.Minutes >= 0)
            {
                iDiferencia = _tsDiferencia.Minutes;
                ctipoValorDiferencia = iDiferencia > 1 ? "Minutos" : "Minuto";
            }

            return iValorDiferenciaFecha;
        }

        public string cTipoValorDiferenciaFecha(string _cTipoValorDiferencia, int _iDiferencia)
        {
            string cTextoTipoDiferencia = string.Empty;
            switch (_cTipoValorDiferencia)
            {
                case "MES":
                    cTextoTipoDiferencia = _iDiferencia > 1 ? "Meses" : "Mes";
                    break;
                case "DIA":
                    cTextoTipoDiferencia = _iDiferencia > 1 ? "Dias" : "Dia";
                    break;
                case "HORAS":
                    cTextoTipoDiferencia = _iDiferencia > 1 ? "Horas" : "Hora";
                    break;
                case "MINUTO":
                    cTextoTipoDiferencia = _iDiferencia > 1 ? "Minutos" : "Minuto";
                    break;
                default:
                    break;
            }

            return cTextoTipoDiferencia;
        }
    }
}
