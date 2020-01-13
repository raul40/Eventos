using RecuperadorEventos.Internaces;
using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos
{
    public class RecuperadorTipoFecha : IRecuperadorTipoFecha
    {

        public List<Archivo> ObtenerTiposFecha(List<Archivo> _lstArchivos)
        { 
            
            foreach (var item in _lstArchivos)
            {
                if (item.tsDiferencia.Days > 31)
                {
                    item.cTipoFecha = "MES";
                }
                else if (item.tsDiferencia.Days > 0)
                {
                    item.cTipoFecha = "DIA";
                }
                else if (item.tsDiferencia.Hours > 0)
                {
                    item.cTipoFecha = "HORA";
                }
                else if (item.tsDiferencia.Minutes >= 0)
                {
                    item.cTipoFecha = "MINUTO";
                }
            }

            return _lstArchivos;
        }

        
    }
}
