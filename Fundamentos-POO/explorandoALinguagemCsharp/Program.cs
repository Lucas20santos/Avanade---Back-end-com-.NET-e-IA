using FundamentosProgramacaoObjeto.Models;

namespace FundamentosProgramacaoObjeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introdução: ->");

            Pessoa p1 = new()
            {
                Nome = "Lucas",
                idade = 19
            };

            p1.apresentar();
        }
    }
}