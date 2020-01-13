using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioEvento.Interfaces
{
    public interface IServicioEvento
    {
        List<Archivo> ObtenerEventos(List<Archivo> _lstArchivo);
    }
}
