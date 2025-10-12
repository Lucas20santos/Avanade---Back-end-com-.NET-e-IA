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
            this._tipoSuite = tipoSuite;
            this._capacidade = capacidade;
            this._valorDiario = valor_diario;
        }
        public TipoSuite TipoSuite 
        {
            get => _tipoSuite;
            set => _tipoSuite = value;
        }
    }
}