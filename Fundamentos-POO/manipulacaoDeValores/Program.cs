using FundamentosProgramacaoObjeto.Models;

namespace FundamentosProgramacaoObjeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 0;

            if (b == 0)
            {
                throw new Exception("Divisão por zero, não pode acontecer.");
            }
            else
            {
                Console.WriteLine($"{a / b}");
            }

        }
    }
}