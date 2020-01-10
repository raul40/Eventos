using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorEventos.Interfaces;
using System.IO;
using RepositorioEventos;

namespace ValidadorEventos
{
    public class ValidadorArchivo : IValidadorArchivo
    {
        public bool ValidarExistenciaArchivo(string _cRuta)
        {
            bool lExisteArchivo = File.Exists(_cRuta);

            return lExisteArchivo;
        }


    }
}
