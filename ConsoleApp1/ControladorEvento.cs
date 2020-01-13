using RepositorioEventos;
using ServicioEvento.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ControladorEvento
    {
        const string cFormatoFecha = "dd/MM/yyyy HH:mm";
        private readonly IServicioVista ServicioVista;
        private readonly IServicioEvento ServicioEvento;
        private readonly IServicioArchivo ServicioArchivo;
        private readonly IServicioFecha ServicioFecha;
        private readonly IServicioTipoFecha ServicioTipoFecha;
        private string cRutaArchivo;

        public ControladorEvento(IServicioVista _ServicioVista, IServicioEvento _ServicioEvento, IServicioArchivo _ServicioArchivo, IServicioFecha _ServicioFecha, IServicioTipoFecha _ServicioTipoFecha)
        {
            this.ServicioVista = _ServicioVista;
            this.ServicioEvento = _ServicioEvento;
            this.ServicioArchivo = _ServicioArchivo;
            this.ServicioFecha = _ServicioFecha;
            this.ServicioTipoFecha = _ServicioTipoFecha;
        }



        public void Init()
        {
            cRutaArchivo = ServicioVista.ObtenerRutaArchivo();
            List<Archivo> lstArchivos = ServicioArchivo.ObtenerArchivo(cRutaArchivo);
            lstArchivos = ServicioFecha.ObtenerDiferenciaFecha(lstArchivos);
            lstArchivos = ServicioTipoFecha.ObtenerTipoFecha(lstArchivos);
            lstArchivos = ServicioFecha.ObtenerValorDiferenciaFecha(lstArchivos);
            lstArchivos = ServicioEvento.ObtenerEventos(lstArchivos);
            ServicioVista.MostrarDatosVista(lstArchivos);
        }

        
    }
}
