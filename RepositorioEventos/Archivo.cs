using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioEventos
{
    public class Archivo
    {
        public string cNombreEvento { get; set; }

        public DateTime dtFechaEvento { get; set; }

        public int iValorDiferencia { get; set; }

        public DateTime dtFechaComparar { get; set; }

        public TimeSpan tsDiferencia { get; set; }

        public string cTipoFecha { get; set; }

        public string cMensajeEvento { get; set; }
    }
}
