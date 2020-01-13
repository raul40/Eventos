using RecuperadorEventos.Internaces;
using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos
{
    public class RecuperadorFechaEvento : IRecuperadorFechaEvento
    {
        public List<Archivo> ObtenerValorDiferenciaFecha(List<Archivo> _lstArchivo)
        {
            foreach (var item in _lstArchivo)
            {
                switch (item.cTipoFecha)
                {
                    case "MES":
                        item.iValorDiferencia = item.tsDiferencia.Days / 31;
                        break;
                    case "DIA":
                        item.iValorDiferencia = item.tsDiferencia.Days;
                        break;
                    case "HORA":
                        item.iValorDiferencia = item.tsDiferencia.Hours;
                        break;
                    case "MINUTO":
                        item.iValorDiferencia = item.tsDiferencia.Minutes;
                        break;
                    default:
                        throw new Exception("El tipo de Fecha no existe");
                }
            }

            return _lstArchivo;
        }

        public List<Archivo> ObtenerDiferenciaFechas(List<Archivo> _lstArchivos)
        {
            foreach (var item in _lstArchivos)
            {
                //if (item.dtFechaComparar > item.dtFechaEvento)
                //{
                //    item.tsDiferencia = item.dtFechaComparar - item.dtFechaEvento;
                //}
                //else
                //{
                //    item.tsDiferencia = item.dtFechaEvento - item.dtFechaComparar;
                //}
                item.tsDiferencia = item.dtFechaComparar - item.dtFechaEvento;
            }

            return _lstArchivos;
        }
    }
}
