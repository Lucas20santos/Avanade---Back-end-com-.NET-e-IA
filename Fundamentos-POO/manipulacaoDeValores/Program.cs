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
            Pessoa p2 = new()
            {
                Nome = "Fernanda",
                Sobrenome = "Maria",
                idade = 32
            };

            Curso c1 = new Curso();
            c1.AdicionarAluno(p1);
            c1.AdicionarAluno(p2);
            c1.ListarAlunos();
        }
    }
}