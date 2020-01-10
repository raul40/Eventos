using RecuperadorEventos.Internaces;
using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos
{
    public class RecuperadorArchivo : IRecuperadorArchivo
    {
        public List<IArchivo> ObtenerContenidoArchivo(string _cRuta)
        {
            Array arrDatos = File.ReadAllLines(_cRuta);
            List<IArchivo> entDatos = ConvertirDatosArchivo(arrDatos);

            return entDatos;
        }

        public List<IArchivo> ConvertirDatosArchivo(Array _arrDatos)
        {
            List<IArchivo> lstDatos = null;
            foreach (string cLinea in _arrDatos)
            {
                IArchivo entArchivo = null;
                entArchivo.cNombreEvento = cLinea.Split(',')[0];
                entArchivo.cFechaEvento = cLinea.Split(',')[1];
                lstDatos.Add(entArchivo);
            }

            return lstDatos;
        }
    }
}
