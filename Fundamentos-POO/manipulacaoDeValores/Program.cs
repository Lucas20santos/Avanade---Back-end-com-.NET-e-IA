using FundamentosProgramacaoObjeto.Models;

namespace FundamentosProgramacaoObjeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> estado = new Dictionary<string, string>();
            estado.Add("Pe", "Pernambuco");
            estado.Add("Ba", "Bahia");
            estado.Add("Mg", "Minas Gerais");
            estado.Add("Sp", "São Paulo");

            foreach (var item in estado)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<string, string> item in estado)
            {
                Console.WriteLine(item);
            }

            string chave = "Ba";
            Console.WriteLine($"Verificando a chave: {chave}");
            if (estado.ContainsKey(chave))
            {
                Console.WriteLine($"A chave {chave} já foi adicionada.");
            }
            else
            {
                Console.WriteLine($"A chave {chave} ainda não foi adicionada.");
            }
        }
    }
}