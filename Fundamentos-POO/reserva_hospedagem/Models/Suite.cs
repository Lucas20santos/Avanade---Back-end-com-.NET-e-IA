namespace reserva_hospedagem.Models
{
    class Suite 
    {
                private string TipoDeSuite;
        private int Capacidade;
        private decimal ValorDiario;
        public Suite(string tiposuite, int capacidade, decimal valor_diario)
        {
            this.TipoDeSuite = tiposuite;
            this.Capacidade = capacidade;
            this.ValorDiario = valor_diario;
        }
        public string GetTipoSuite()
        {
            return this.TipoDeSuite;
        }
        public void SetTipoSuite(string suite)
        {
            this.TipoDeSuite = suite;
        }
        public int GetCapacidade()
        {
            return this.Capacidade;
        }
        public void SetCapacidade(int capacidade)
        {
            this.Capacidade = capacidade;
        }
        public decimal GetValorDiarioDaReserva()
        {
            return this.ValorDiario;
        }
        public void SetValorDiarioDaReserva(decimal valor)
        {
            this.ValorDiario = valor;
        }
    }
}