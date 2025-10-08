using System.Globalization;
using System.Threading;

namespace FundamentosProgramacaoObjeto.Models
{
    class Curso
    {
        public string Nome_Curso { get; set; }
        public List<Pessoa> Alunos = new List<Pessoa>();
        public decimal Valor { get; set; }
        public int VagasMaxima { get; set;  }
        public void AdicionarAluno(Pessoa alunos)
        {
            Alunos.Add(alunos);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidadeAlunos = Alunos.Count;
            return quantidadeAlunos;
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            int cont = 1;
            foreach (var item in Alunos)
            {
                Console.WriteLine($"{cont}º - {item.Nome}");
                cont++;
            }
        }
        public void apresentarCurso()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            Console.WriteLine($"Curso: {this.Nome_Curso}");
            Console.WriteLine($"Preço: {this.Valor:C}"); // essa formatação vem da declaração acima
            Console.WriteLine(this.Valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // essa formatação é criada aqui
            Console.WriteLine(this.Valor.ToString("C1")); // C + Numero => Representa o numero de casas decimais que serão representadas.
            Console.WriteLine($"Quantidade de Matriculados: {Alunos.Count}");
            Console.WriteLine($"Quantidade Máxima Permitida: {this.VagasMaxima}");
        }
    }
}