using Calculadora.Services;

namespace CalculadoraTests
{
    public class ValidacoesStringsTests
    {
        private ValidacoesStrings _val;

        public ValidacoesStringsTests()
        {
            _val = new ValidacoesStrings();
        }
        
        [Fact]
        public void ContarCaracteresDeTextoHelloERetornar5()
        {
            string texto = "Hello";
            int resultado = _val.ContarCaracteres(texto);
            Assert.Equal(resultado, 5);
        }
    }
}