using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangulos.ConsoleApp;

namespace Triangulos.Tests
{
    [TestClass]
    public class TrianguloTest
    {
        [TestMethod]
        public void DeveVerificarTiposDeTriangulos()
        {
            Triangulo equilatero = new Triangulo(3, 3, 3);
            Triangulo isoceles = new Triangulo(3, 3, 1);
            Triangulo escaleno = new Triangulo(4, 3, 2);
            Triangulo invalido = new Triangulo(3, 2, 1);

            string resultadoEquilatero = equilatero.validar();
            string resultadoIsoceles = isoceles.validar();
            string resultadoEscaleno = escaleno.validar();
            string resultadoInvalido = invalido.validar();

            Assert.AreEqual("Triangulo equilátero", resultadoEquilatero);
            Assert.AreEqual("Triangulo isóceles", resultadoIsoceles);
            Assert.AreEqual("Triangulo escaleno", resultadoEscaleno);
            Assert.AreEqual("Triangulo inválido", resultadoInvalido);
        }
    }
}
