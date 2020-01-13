using RecuperadorEventos.Internaces;
using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos
{
    public class RecuperadorArchivo : IRecuperadorArchivo
    {
        private const string cFormatoFecha = "dd/MM/yyyy HH:mm";

        public List<Archivo> ObtenerContenidoArchivo(string _cRuta)
        {
            Array arrDatos = File.ReadAllLines(_cRuta);
            List<Archivo> entDatos = ConvertirDatosArchivo(arrDatos);

            return entDatos;
        }

        private List<Archivo> ConvertirDatosArchivo(Array _arrDatos)
        {
            List<Archivo> lstDatos = new List<Archivo>();
            foreach (string cLinea in _arrDatos)
            {
                Archivo entArchivo = new Archivo();
                entArchivo.cNombreEvento = cLinea.Split(',')[0];
                entArchivo.dtFechaEvento = DateTime.ParseExact(cLinea.Split(',')[1], cFormatoFecha, CultureInfo.InvariantCulture);
                entArchivo.iValorDiferencia = 0;
                entArchivo.dtFechaComparar = DateTime.Now;
                lstDatos.Add(entArchivo);
            }

            return lstDatos;
        }
    }
}
