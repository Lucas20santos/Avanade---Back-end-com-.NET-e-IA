namespace reserva_hospedagem.Models
{
    class Suite
    {
        private TipoSuite _tipoSuite;
        private int _capacidade;
        private decimal _valorDiario;
        public Suite() { }
        public Suite(TipoSuite tipoSuite, int capacidade, decimal valor_diario)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiario = valor_diario;
        }
        // Fazendo validação do Enum para caso o valor vier de uma fonte externa
        public TipoSuite TipoSuite
        {
            get => _tipoSuite;
            set
            {
                if (!Enum.IsDefined(typeof(TipoSuite), value)) throw new ArgumentException("Tipo de suíte invlálido.");
                _tipoSuite = value;
            }
        }
        public int Capacidade
        {
            get => _capacidade;
            set
            {
                if(value < 1) throw new ArgumentException("Valor informado não está correto, por favor corrija.");
                _capacidade = value;
            }
        }
        public decimal ValorDiario
        {
            get => _valorDiario;
            set
            {
                if (value <= 0) throw new ArgumentException("Valor negativo para o preço da Suite não é aceito. Por favor, corrija.");
                _valorDiario = value;
            }
        }
    }
}