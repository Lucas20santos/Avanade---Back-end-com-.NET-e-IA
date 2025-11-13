# Desafio de Projeto

## Projeto

```bash
    dotnet new console -n Calculadora
    dotnet new xunit -n CalculadoraTests

    # Criando uma solution
    dotnet new sln -n CalculadoraSolution

    # Adicionando os projetos na solution
    dotnet sln add Calculadora/Calculadora.csproj
    dotnet sln add CalculadoraTests/CalculadoraTests.csproj

    # Adicionando a referencia do meu projeto console dentro do meu projeto tests
    cd CalculadoraTests
    dotnet add reference ../Calculadora/Calculadora.csproj
```

## Criando testes

```cs
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
```

### Executando o teste

```bash

cd CalculadoraTests
dotnet test
```

```cs
    using DesafioProjeto.Services;
using Xunit;

namespace DesafioProjetoTests
{
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validacoes = new ValidacoesLista();

        // 🔹 Fonte de dados para os testes
        public static IEnumerable<object[]> ListasDeTeste =>
            new List<object[]>
            {
                // Caso 1: mistura de positivos e negativos
                new object[] { new List<int> { 5, 6, 7, -8, 9 }, new List<int> { 5, 6, 7, 9 } },

                // Caso 2: apenas positivos
                new object[] { new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3, 4 } },

                // Caso 3: apenas negativos
                new object[] { new List<int> { -1, -2, -3 }, new List<int>() },

                // Caso 4: contendo zero
                new object[] { new List<int> { -1, 0, 1 }, new List<int> { 1 } },

                // Caso 5: lista vazia
                new object[] { new List<int>(), new List<int>() },

                // Caso 6: valores repetidos
                new object[] { new List<int> { -1, 2, 2, 3, -4, 3 }, new List<int> { 2, 2, 3, 3 } },

                // Caso 7: valores extremos
                new object[] { new List<int> { int.MinValue, -1, 0, 1, int.MaxValue }, new List<int> { 1, int.MaxValue } },
            };

        // 🔹 Teste principal com [MemberData]
        [Theory]
        [MemberData(nameof(ListasDeTeste))]
        public void ObterSomenteNumerosPositivos_DeveRetornarApenasNumerosPositivos(List<int> listaOriginal, List<int> listaEsperada)
        {
            // Act
            var resultado = _validacoes.ObterSomenteNumerosPositivos(listaOriginal);

            // Assert
            Assert.Equal(listaEsperada, resultado);
        }

        // 🔹 Teste adicional para caso nulo
        [Fact]
        public void ObterSomenteNumerosPositivos_DeveLancarExcecao_QuandoListaForNula()
        {
            // Arrange
            List<int>? lista = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _validacoes.ObterSomenteNumerosPositivos(lista!));
        }
    }
}
```
