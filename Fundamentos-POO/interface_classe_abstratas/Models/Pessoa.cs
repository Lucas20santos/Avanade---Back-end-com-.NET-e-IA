class Pessoa
    {
        public string? nome;
        public int idade;

        public virtual void apresentar()
        {
            Console.WriteLine($"A pessoa, {nome} de {idade} anos.");
        }        
    }