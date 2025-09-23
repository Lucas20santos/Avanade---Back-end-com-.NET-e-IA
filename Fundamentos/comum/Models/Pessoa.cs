namespace comum.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public int idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
        }
    }
}
