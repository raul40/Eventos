using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioEventos
{
    public interface IArchivo
    {
        string cNombreEvento { get; set; }
        string cFechaEvento { get; set; }
    }
}
