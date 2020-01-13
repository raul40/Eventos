using RepositorioEventos;
using ServicioEvento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioEvento
{
    public class ServicioVista : IServicioVista
    {
        public void MostrarDatosVista(List<Archivo> _lstArchivo)
        {
            foreach (var item in _lstArchivo)
            {
                Console.WriteLine(item.cMensajeEvento);
            }
            Console.ReadLine();
        }

        public string ObtenerRutaArchivo()
        {
            Console.WriteLine("Escribe la ruta del archivo: ");
            return Console.ReadLine();
        }
    }
}
