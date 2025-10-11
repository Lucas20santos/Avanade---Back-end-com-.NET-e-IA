namespace reserva_hospedagem.Models
{
    class Reserva
    {
        private List<Pessoa> hospedes = new List<Pessoa>();
        private Suite suite;
        private int DiasDeReservas;
        public Reserva(Suite suite, int diasdereserva)
        {
            this.suite = suite;
            this.DiasDeReservas = diasdereserva;
        }
        public void CadastrarHospedes(Pessoa pessoa)
        {
            this.hospedes.Add(pessoa);
        }
        public void CadastrarSuite(Suite suite)
        {
            this.suite = suite;
        }        
        public int ObterQuantidadeHospedes()
        {
            return this.hospedes.Count;
        }        
        public decimal CalcularValorHospedagem(Suite suite)
        {
            return this.DiasDeReservas * suite.GetValorDiarioDaReserva();
        }
    }
}