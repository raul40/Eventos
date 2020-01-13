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
    public class RecuperadorEventoTests
    {
        [TestMethod()]
        public void ObtenerEventosTest()
        {
            //Arrange
            var lst = new List<Archivo>();
            lst.Add(new Archivo()
            {
                cNombreEvento = "Pruba",
                iValorDiferencia = 1,
                dtFechaComparar = DateTime.Now,
                dtFechaEvento = DateTime.Now.AddMonths(1),
                cTipoFecha = "MES",
            });

            var resultadoEsperado = lst;
            resultadoEsperado[0].cMensajeEvento = "Pruba, ocurrirá dentro de 1 MES";

            //Act
            var SUT = new RecuperadorEvento();
            var respuesta = SUT.ObtenerEventos(lst);

            //Assert
            Assert.AreEqual(resultadoEsperado, respuesta);
        }
    }
}