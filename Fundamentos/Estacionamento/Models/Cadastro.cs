using Estacionamento.Models;

namespace Fundation.Models
{
    class Cadastro
    {

        public void cadastrarNome(Cliente cliente)
        {
            Console.Write($"Informe o Nome: ");
            cliente.Nome = Console.ReadLine();
        }

        public void cadastrarSobrenome(Cliente cliente)
        {
            Console.Write($"Informe o Sobrenome: ");
            cliente.Sobrenome = Console.ReadLine();
        }

        public void cadastrarCPF(Cliente cliente)
        {
            Console.Write($"Informe o CPF: ");
            cliente.CPF = Console.ReadLine();
        }
        public void cadastrarPlaca(Automovel automovel)
        {
            Console.Write($"Informe a Placa do Veículo: ");
            automovel.placa = Console.ReadLine();
        }
        public void cadastrarModelo(Automovel automovel)
        {
            Console.Write($"Informe o Modelo do Veículo: ");
            this.automovel.modelo = Console.ReadLine();
        }
        public void cadastrarCor(Automovel automovel)
        {
            Console.Write($"Informe a Cor do Veículo: ");
            this.automovel.cor = Console.ReadLine();
        }
        public void cadastrarMarca(Automovel automovel)
        {
            Console.Write($"Informe a Marca do Veículo: ");
            this.automovel.marca = Console.ReadLine();
        }
        public void cadastrarQuantidadeRodas()
        {
            Console.Write($"Informe a Quantidade de Rodas do Veículo: ");
            this.automovel.quantidadeRodas = Convert.ToInt32(Console.ReadLine());
        }

        public void apresentarCadastro(Cliente cliente, Automovel automovel)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Sobrenome: {cliente.Sobrenome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Placa do Veículo: {cliente.CPF}");

            Console.WriteLine($"Modelo: {automovel.modelo}");
            Console.WriteLine($"Modelo: {automovel.marca}");
            Console.WriteLine($"Modelo: {automovel.cor}");
            Console.WriteLine($"Modelo: {automovel.quantidadeRodas}");
        }
    }
}