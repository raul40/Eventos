using RepositorioEventos;
using System.Collections.Generic;

namespace RecuperadorEventos
{
    public interface IRecuperadorEvento
    {
        List<Archivo> ObtenerEventos(List<Archivo> _lstArchivo);
    }
}