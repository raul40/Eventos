using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioEvento.Interfaces
{
    public interface IServicioFecha
    {
        List<Archivo> ObtenerDiferenciaFecha(List<Archivo> _lstArchivo);

        List<Archivo> ObtenerValorDiferenciaFecha(List<Archivo> _lstArchivo);
    }
}
