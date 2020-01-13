using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecuperadorEventos;
using RepositorioEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperadorEventos.Tests
{
    [TestClass()]
    public class RecuperadorTipoFechaTests
    {
        [TestMethod()]
        public void ObtenerTiposFecha_SinDatos_DevuelveListaVacia()
        {

            var lst = new List<Archivo>();
            var sut = new RecuperadorTipoFecha();

            var respuesta = sut.ObtenerTiposFecha(lst);
            Assert.AreEqual(lst, respuesta);
        }

        [TestMethod()]
        public void ObtenerTiposFecha_UnRegistro_DevuelveListaConDatos()
        {
            var lst = new List<Archivo>();
            lst.Add(new Archivo
            {
                tsDiferencia = TimeSpan.Parse("1")
            });
            var resultado = lst;
            resultado[0].cTipoFecha = "DIA";
            var sut = new RecuperadorTipoFecha();

            var respuesta = sut.ObtenerTiposFecha(lst);
            Assert.AreEqual(resultado, respuesta);
        }
    }
}