using NUnit.Framework;
using MiServicio;

[TestFixture]
public class CalculadoraTest
{
    [Test]
    public void Sumar_DosNumeros_RetornaResultadoCorrecto()
    {
        // Arrange
        var calc = new Calculadora();

        // Act
        int resultado = calc.Sumar(3, 3);

        // Assert
        Assert.That(resultado, Is.EqualTo(6));
    }

      [Test]
    public void Restar_NumeroPequenioDeNumeroGrande_RetornaDiferencia()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Restar(10, 3);

        // Assert
        Assert.That(resultado, Is.EqualTo(7));
    }

    [Test]
    public void Multiplicar_DosNumeros_RetornaProducto()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Multiplicar(4, 5);

        // Assert
        Assert.That(resultado, Is.EqualTo(20));
    }
}