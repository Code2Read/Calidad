using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverage
{
    [TestClass]
    public class TrianguloTest
    {
[TestMethod]
        public void Validar_AngulosMenoresCero_RetornaTrianguloInvalido()
{
    //Arrange
    var triangulo = new Triangulo();

    //Act
    var resultado = triangulo.Validar(0, 0, 0);

    //Assert
    Assert.AreEqual("Triangulo Inválido", resultado);
}


[TestMethod]
public void Validar_AngulosInvalidos_RetornaTrianguloInvalido()
{
    //Arrange
    var triangulo = new Triangulo();

    //Act
    var resultado = triangulo.Validar(17, 8, 8);

    //Assert
    Assert.AreEqual("Triangulo Inválido", resultado);
}


    }
}
