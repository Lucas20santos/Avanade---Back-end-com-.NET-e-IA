using Estacionamento.Models;
using Fundation.Models;

namespace Estacionamento.Models
{
    class Estacionamentos
    {
        Cadastro cadastro = new Cadastro();
        private List<string> veiculos = new List<string>();
        public string? placaVeiculo { get; set; }

        public void cadastrarCliente(Cliente cliente)
        {
            cadastro.cadastrarNome(cliente);
            cadastro.cadastrarSobrenome(cliente);
            cadastro.cadastrarCPF(cliente);
        }

        public void cadastrarAutomovel()
        {
            cadastro.cadastrarModelo();
            cadastro.cadastrarMarca();
            cadastro.cadastrarCor();
            cadastro.cadastrarQuantidadeRodas();
        }

        public void AdicionarVeiculo(string? placa)
        {
            this.placaVeiculo = placa;
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
            Console.Write("Informe a Placa do Veiculo: ");
            string? placa = Console.ReadLine();

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