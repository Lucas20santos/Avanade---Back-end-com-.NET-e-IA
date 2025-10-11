namespace reserva_hospedagem.Models
{
    class Pessoa 
    {
        private string Nome;
        private string Sobrenome;
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public string GetSobrenome()
        {
            return this.Sobrenome;
        }
        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
    }
}