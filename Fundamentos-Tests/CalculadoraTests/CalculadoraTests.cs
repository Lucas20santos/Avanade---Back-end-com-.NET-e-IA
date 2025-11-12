using Calculadora.Services;


namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange: Serve para montar o meu cenário
        int num1 = 5;
        int num2 = 10;
        //Act: Chamar o cenário para o que ele deve fazer
        int resultado = _calc.Somar(num1, num2);
        // Assert: Para validade se o resultado é o esperado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10De5ERetornar5()
    {
        int num1 = 10;
        int num2 = 5;
        int resultado = _calc.Subtrair(num1, num2);
        Assert.Equal(5, resultado);
    }
    [Fact]
    public void DeveMultiplicar10Com5ERetornar50()
    {
        int num1 = 10;
        int num2 = 5;
        int resultado = _calc.Multiplicar(num1, num2);
        Assert.Equal(50, resultado);
    }
    [Fact]
    public void DeveDividir10Com5ERetornarUm2Float()
    {
        double num1 = 10;
        double num2 = 5;
        double resultado = _calc.Dividir(num1, num2);
        Assert.Equal(2.0, resultado);
    }
    [Fact]
    public void DeveRetornaZeroPoisNum2EIgualAZero()
    {
        double num1 = 10;
        double num2 = 0;
        double resultado = _calc.Dividir(num1, num2);
        Assert.Equal(0.0, resultado);        
    }
}