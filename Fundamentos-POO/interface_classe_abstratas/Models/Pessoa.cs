namespace interface_classe_abstratas.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }

        protected Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public abstract void apresentar();
    }
}