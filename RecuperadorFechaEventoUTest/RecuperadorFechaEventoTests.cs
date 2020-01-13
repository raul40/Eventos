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
    public class RecuperadorFechaEventoTests
    {
        [TestMethod()]
        public void ObtenerValorDiferenciaFecha_UnMesDiferencia_ListaConValorDiferenciaNegativo()
        {
            //Arrange
            var lst = new List<Archivo>();
            lst.Add(new Archivo()
            {
                cNombreEvento = "Pruba",
                dtFechaComparar = DateTime.Now,
                dtFechaEvento = DateTime.Now.AddMonths(1),
                cTipoFecha = "MES",
            });

            var resultadoEsperado = lst;
            resultadoEsperado[0].iValorDiferencia = -1;
            //Act
            var SUT = new RecuperadorFechaEvento();
            var resultado = SUT.ObtenerDiferenciaFechas(lst);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod()]
        public void ObtenerDiferenciaFechas_UnMesDiferencia_ListaConTimeSpanActualizado()
        {
            //Arrange
            var lst = new List<Archivo>();
            lst.Add(new Archivo()
            {
                cNombreEvento = "Pruba",
                dtFechaComparar = DateTime.Now,
                dtFechaEvento = DateTime.Now.AddMonths(1),
                cTipoFecha = "MES",
            });

            var resultadoEsperado = lst;
            resultadoEsperado[0].tsDiferencia = resultadoEsperado[0].dtFechaComparar - resultadoEsperado[0].dtFechaEvento;
            //Act
            var SUT = new RecuperadorFechaEvento();
            var resultado = SUT.ObtenerDiferenciaFechas(lst);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}