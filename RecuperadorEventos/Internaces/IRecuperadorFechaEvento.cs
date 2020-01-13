using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos.Internaces
{
    public interface IRecuperadorFechaEvento
    {

        List<Archivo> ObtenerValorDiferenciaFecha(List<Archivo> _lstArchivos);

        List<Archivo> ObtenerDiferenciaFechas(List<Archivo> _lstArchivos);

        //List<Archivo> cTipoValorDiferenciaFecha(string _cTipoValorDiferencia, int _iDiferencia);
    }
}
