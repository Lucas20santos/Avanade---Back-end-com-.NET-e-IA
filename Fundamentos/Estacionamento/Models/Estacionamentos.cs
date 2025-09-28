namespace Estacionamento.Models
{
    class Estacionamentos
    {
        Custo c1 = new Custo();
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamentos(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string? placa;
            Console.WriteLine("Informe a Placa do Veiculo: ");
            placa = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(placa))
            {
                this.veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Placa inválida. Veículo não adicionado.");
            }
        }

        public void RemoverVeiculo()
        {            

        }

        public void ListarVeiculos()
        {

        }
    }
}