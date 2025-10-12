namespace reserva_hospedagem.Models
{
    class Pessoa 
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            this._nome = nome;
            this._sobrenome = sobrenome;
        }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 2)
                {
                    throw new ArgumentException("Nome deve ter pelos menos 2 caracteres ou não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length > 2)
                {
                    throw new ArgumentException("Nome deve ter pelos menos 2 caracteres ou não pode ser vazio");
                }
            }
        }
    }
}