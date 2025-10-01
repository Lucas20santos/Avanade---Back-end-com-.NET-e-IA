using System.Net.Http.Headers;

namespace Estacionamento.Models
{
    class Estacionamentos
    {
        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.Clear();
            string? placa;
            Console.Write("Informe a Placa do Veiculo: ");
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
            Console.Clear();
            string? placa;
            Console.Write("Informe a Placa do Veiculo: ");
            placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa) && this.veiculos.Contains(placa))
            {
                this.veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Placa inválida. Veículo não se encontra no pátio.");
            }            

        }

        public void ListarVeiculos()
        {
            if(this.veiculos.Any() && veiculos != null)
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionadas são: ");
                int cont = 0;
                foreach (var item in this.veiculos)
                {
                    cont++;
                    Console.WriteLine($"{cont} - {item}.");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionadas.");
            }
        }
    }
}