using DesafioProjeto.Services;

namespace DesafioProjetoTests
{
    public class ValidacaoListaTests
    {
        private readonly ValidacoesLista _validacoes;
        
        public ValidacaoListaTests()
        {
            _validacoes = new ValidacoesLista();
        }
        public static IEnumerable<object[]> ListasDeTeste => new List<object[]>
        {
            new object[] {new List<int> {5, 6, 7, -8, 9},   new List<int> {5, 6, 7, 9}},
            new object[] {new List<int> {1, 2, 3, 4},       new List<int> {1, 2, 3, 4} },
            new object[] {new List<int> {-1, -2, -3},       new List<int>() },
            new object[] {new List<int> {-1, 0, 1},         new List<int> {0, 1} },
            new object[] {new List<int> (), new List<int>() },
            new object[] {new List<int> {-1, 2, 3, 3, -4, 3}, new List<int> {2, 3, 3, 3} },
            new object[] { new List<int> {int.MinValue, -1, 0, 1, int.MaxValue}, new List<int> {0, 1, int.MaxValue}}
        };
        [Theory]
        [MemberData(nameof(ListasDeTeste))]
        public void RemoverNumerosNegativos_DeveRetornarUmaListaSemNumerosNegativo_QuandoPassadoListaContendoNumeroNegativoOuNao
        (List<int> listaOrginal, List<int> listaEsperada)
        {
            // Arrange
            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(listaOrginal);

            // Assert
            Assert.Equal(listaEsperada, resultado);
        }
        [Fact]
        public void ObterSomenteNumerosPositivos_DeveLancarExcecao_QuandoListaForNula()
        {
            // Arrange
            List<int>? lista = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _validacoes.RemoverNumerosNegativos(lista!));
        }
    }
}