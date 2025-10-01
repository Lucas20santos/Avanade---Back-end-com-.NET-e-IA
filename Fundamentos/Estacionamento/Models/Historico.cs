namespace Estacionamento.Models
{
    class Historico
    {
        public List<string> historicoEntrada = new List<string>();
        public List<string> historicoSaida = new List<string>();

        public void atualizarHistoricoEntrada(Cliente cliente, Estacionamentos estacionamento)
        {
            this.historicoEntrada.Add("");
        }

        public void atualizarHistoricoSaida()
        {

        }

        public void mostrarHistorico()
        {
            foreach (var item in historicoEntrada)
            {
                Console.WriteLine($"");
            }
        }
    }
}