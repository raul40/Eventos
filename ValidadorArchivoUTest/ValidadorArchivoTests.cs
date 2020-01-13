using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidadorEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorEventos.Tests
{
    [TestClass()]
    public class ValidadorArchivoTests
    {
        [TestMethod()]
        public void ValidarExistenciaArchivo_ArchivoNoExiste_DevuelveFalse()
        {
            //Arrange
            var cRuta = "X:\\Capacitacion\\Prueba.txt";
            var SUT = new ValidadorArchivo();

            //Act
            var res = SUT.ValidarExistenciaArchivo(cRuta);

            //Assert
            Assert.AreEqual(false, res);
        }

        [TestMethod()]
        public void ValidarExistenciaArchivo_ArchivoExiste_DevuelveTrue()
        {
            //Arrange
            var cRuta = "C:\\Capacitacion\\Prueba.txt";
            var SUT = new ValidadorArchivo();

            //Act
            var res = SUT.ValidarExistenciaArchivo(cRuta);

            //Assert
            Assert.AreEqual(true, res);
        }
    }
}