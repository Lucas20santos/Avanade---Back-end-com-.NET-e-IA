namespace FundamentosProgramacaoObjeto.Models
{
    class Curso
    {
        public string? Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
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
    }
}