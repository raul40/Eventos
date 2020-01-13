using RecuperadorEventos;
using RecuperadorEventos.Internaces;
using RepositorioEventos;
using ServicioEvento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorEventos.Interfaces;

namespace ServicioEvento
{
    public class ServicioEvento : IServicioEvento
    {
        private readonly IRecuperadorEvento RecuperadorEvento;

        public ServicioEvento(IRecuperadorEvento _RecuperadorEvento)
        {
            this.RecuperadorEvento = _RecuperadorEvento;
        }

        public List<Archivo> ObtenerEventos(List<Archivo> _lstArchivo)
        {
            
            return RecuperadorEvento.ObtenerEventos(_lstArchivo);
            
        }

    }
}
