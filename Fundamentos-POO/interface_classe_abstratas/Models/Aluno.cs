namespace interface_classe_abstratas.Models
{
    class Aluno : Pessoa
    {
        public double nota;

        public override void apresentar()
        {
            Console.WriteLine($"O aluno, {nome} de {idade} anos e tenho nota {nota}.");
        }
    }
}