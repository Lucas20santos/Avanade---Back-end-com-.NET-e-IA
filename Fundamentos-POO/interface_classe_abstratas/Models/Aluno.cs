using System.Globalization;

namespace interface_classe_abstratas.Models
{
    class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade) { }
        public double nota;
        public override void apresentar()
        {
            Console.WriteLine($"O aluno, {Nome} de {Idade} anos e tenho nota {nota}.");
        }
    }
}