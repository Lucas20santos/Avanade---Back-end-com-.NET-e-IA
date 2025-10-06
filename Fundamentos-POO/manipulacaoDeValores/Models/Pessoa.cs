namespace FundamentosProgramacaoObjeto.Models
{
    class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome
        {
            get => _nome;
            set
            {
                if (value == "") throw new ArgumentException("O nome não pode ser vazio.");
                _nome = value;
            }
        }
        public int idade
        {
            get => _idade;
            set
            {
                if (value < 0) throw new ArgumentException("Idade não pode recebe um valor negativo.");
                _idade = value;
            } 
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "") throw new ArgumentException("Sobrenome não pode ser vázio.");
                _sobrenome = value;
            }
        }
        public void apresentar()
        {
            Console.WriteLine($"Olá, me chamo {this._nome} e tenho {this._idade}.");
        }
    }
}