using RecuperadorEventos;
using RecuperadorEventos.Internaces;
using ServicioEvento;
using ServicioEvento.Interfaces;
using System;
using System.Globalization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        const string cFormatoFecha = "dd/MM/yyyy HH:mm";


        static void Main(string[] args)
        {
            IServicioVista SrvVista = new ServicioVista();
            IRecuperadorArchivo RecArchivo = new RecuperadorArchivo();
            IServicioArchivo SrvArchivo = new ServicioArchivo(RecArchivo);
            IRecuperadorEvento RecEvento = new RecuperadorEvento();
            IServicioEvento SrvEvento = new ServicioEvento.ServicioEvento(RecEvento);
            IRecuperadorFechaEvento RecFecha = new RecuperadorFechaEvento();
            IServicioFecha SrvFecha = new ServicioFecha(RecFecha);
            IRecuperadorTipoFecha RecTipoFecha = new RecuperadorTipoFecha();
            IServicioTipoFecha SrvTipoFecha = new ServicioTipoFecha(RecTipoFecha);

            ControladorEvento CtrlEvento = new ControladorEvento(SrvVista, SrvEvento, SrvArchivo, SrvFecha, SrvTipoFecha);
            CtrlEvento.Init();
        }
    }
}

//        private static void IniciarApp()
//        {
//            Console.Clear();
//            try
//            {
//                string cRuta = string.Empty;
//                bool lExisteArchivo = false;

//                Console.WriteLine("Escriba la ruta del archivo: ");
//                cRuta = Console.ReadLine();
//                lExisteArchivo = File.Exists(cRuta);

//                if (lExisteArchivo)
//                {
//                    Console.WriteLine("Archivo Validado");
//                    LeerArchivo(cRuta);
//                }
//                else
//                {
//                    Console.WriteLine("No existe el archivo, favor de validar");
//                    IniciarApp();
//                }
//            }
//            catch (Exception ex)
//            {
//                EnviarMensajeError(ex.Message);
//                IniciarApp();
//            }
//            Console.ReadLine();
//            IniciarApp();
//        }

//        private static void EnviarMensajeError(string _cMensaje)
//        {
//            Console.WriteLine(_cMensaje);
//            Console.ReadLine();
//        }

//        private static void LeerArchivo(string cRuta)
//        {
//            var Archivo = File.ReadAllLines(cRuta);
//            if (Archivo.Length > 0)
//            {
//                MostrarMensajes(Archivo);
//            }

//        }

//        private static void MostrarMensajes(string[] archivo)
//        {
//            string cMensaje = string.Empty;
//            string cTextoFecha = string.Empty;
//            foreach (var item in archivo)
//            {
//                if (item.Contains(","))
//                {
//                    string cNombreEvento = item.Split(",")[0];
//                    string cFecha = item.Split(",")[1];

//                    DateTime dtFechaEvento = ValidarFecha(cFecha);

//                    cTextoFecha = ObtenerTextoPorFecha(dtFechaEvento);

//                    Console.WriteLine(string.Format("{0} {1}", cNombreEvento, cTextoFecha));
//                }
//            }
//        }

//        private static string ObtenerTextoPorFecha(DateTime _dtFechaEvento)
//        {
//            DateTime dtActual = DateTime.Now;
//            TimeSpan tsDiferencia;
//            bool lEsFechaAntigua;
//            string cTexto = string.Empty;
//            string cTextoTiempo = string.Empty;
//            string cTextoFechaEvento = string.Empty;

//            if (dtActual >= _dtFechaEvento)
//            {
//                tsDiferencia = dtActual - _dtFechaEvento;
//                lEsFechaAntigua = true;
//                cTexto = "ocurrió hace";
//            }
//            else
//            {
//                tsDiferencia = _dtFechaEvento - dtActual;
//                lEsFechaAntigua = false;
//                cTexto = "ocurrirá dentro de";
//            }

//            cTextoTiempo = ObtenerDiferenciaTiempo(tsDiferencia);
//            cTextoFechaEvento = string.Format("{0} {1}", cTexto, cTextoTiempo);
//            return cTextoFechaEvento;
//        }

//        private static string ObtenerDiferenciaTiempo(TimeSpan _tsDiferencia)
//        {
//            string cTiempo = string.Empty;
//            string cUnidadTiempo = string.Empty;
//            int iDiferencia = 0;

//            if (_tsDiferencia.Days > 31)
//            {
//                iDiferencia = _tsDiferencia.Days / 31;
//                cUnidadTiempo = iDiferencia > 1 ? "Meses" : "Mes";
//            }
//            else if (_tsDiferencia.Days > 0)
//            {
//                iDiferencia = _tsDiferencia.Days;
//                cUnidadTiempo = iDiferencia > 1 ? "Dias" : "Dia";
//            }
//            else if (_tsDiferencia.Hours > 0)
//            {
//                iDiferencia = _tsDiferencia.Hours;
//                cUnidadTiempo = iDiferencia > 1 ? "Horas" : "Hora";
//            }
//            else if (_tsDiferencia.Minutes >= 0)
//            {
//                iDiferencia = _tsDiferencia.Minutes;
//                cUnidadTiempo = iDiferencia > 1 ? "Minutos" : "Minuto";
//            }

//            cTiempo = string.Format("{0} {1}", iDiferencia.ToString(), cUnidadTiempo);

//            return cTiempo;
//        }

//        private static DateTime ValidarFecha(string cFecha)
//        {
//            DateTime dtFecha = DateTime.ParseExact(cFecha, cFormatoFecha, CultureInfo.InvariantCulture);
//            return dtFecha;
//        }
//    }
//}
