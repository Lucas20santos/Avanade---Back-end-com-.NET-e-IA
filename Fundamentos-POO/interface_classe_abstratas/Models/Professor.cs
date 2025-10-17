namespace interface_classe_abstratas.Models
{
    public sealed class Professor : Pessoa
    {
        public double salario;
        public Professor(string nome, int idade) : base(nome, idade) { }
        public override void apresentar()
        {
            Console.WriteLine($"O professor {Nome} de {Idade} anos e tenho salario {salario}.");
        }
    }
}