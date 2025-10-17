namespace interface_classe_abstratas.Models
{
    class Professor : Pessoa
    {
        public double salario;

        public override void apresentar()
        {
            Console.WriteLine($"O professor {nome} de {idade} anos e tenho salario {salario}.");
        }
    }
}