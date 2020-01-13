using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioEvento.Interfaces
{
    public interface IServicioArchivo
    {
        List<Archivo> ObtenerArchivo(string _cRutaArchivo);
    }
}
