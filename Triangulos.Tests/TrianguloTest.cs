using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangulos.ConsoleApp;

namespace Triangulos.Tests
{
    [TestClass]
    public class TrianguloTest
    {
        [TestMethod]
        public void DeveSerTrianguloEquilatero()
        {
            Triangulo equilatero = new Triangulo(3, 3, 3);            

            string resultadoEquilatero = equilatero.validar();            

            Assert.AreEqual("Triangulo equilátero", resultadoEquilatero);            
        }

        [TestMethod]
        public void DeveSerTrianguloIsoceles()
        {
            Triangulo isoceles = new Triangulo(3, 3, 1);

            string resultadoIsoceles = isoceles.validar();

            Assert.AreEqual("Triangulo isóceles", resultadoIsoceles);
        }

        [TestMethod]
        public void DeveSerTrianguloEscaleno()
        {
            Triangulo escaleno = new Triangulo(4, 3, 2);

            string resultadoEscaleno = escaleno.validar();

            Assert.AreEqual("Triangulo escaleno", resultadoEscaleno);
        }


        [TestMethod]
        public void DeveSerTrianguloInvalido()
        {
            Triangulo invalido = new Triangulo(3, 2, 1);

            string resultadoInvalido = invalido.validar();

            Assert.AreEqual("Triangulo inválido", resultadoInvalido);
        }
    }
}
