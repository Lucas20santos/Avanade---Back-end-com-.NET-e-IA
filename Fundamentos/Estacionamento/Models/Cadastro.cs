using Estacionamento.Models;

namespace Fundation.Models
{
    class Cadastro
    {
        Cliente cliente = new Cliente();
        Automovel automovel = new Automovel();

        public void cadastrarNome()
        {
            Console.WriteLine($"Informe o Nome: ");
            this.cliente.Nome = Console.ReadLine();
        }

        public void cadastrarSobrenome()
        {
            Console.WriteLine($"Informe o Sobrenome: ");
            this.cliente.Sobrenome = Console.ReadLine();
        }

        public void cadastrarCPF()
        {
            Console.WriteLine($"Informe o CPF: ");
            this.cliente.CPF = Console.ReadLine();
        }
        public void cadastrarPlaca()
        {
            Console.WriteLine($"Informe a Placa do Veículo: ");
            this.automovel.placa = Console.ReadLine();
        }
        public void cadastrarModelo()
        {
            Console.WriteLine($"Informe o Modelo do Veículo: ");
            this.automovel.modelo = Console.ReadLine();
        }
        public void cadastrarCor()
        {
            Console.WriteLine($"Informe a Cor do Veículo: ");
            this.automovel.cor = Console.ReadLine();
        }
        public void cadastrarMarca()
        {
            Console.WriteLine($"Informe a Marca do Veículo: ");
            this.automovel.marca = Console.ReadLine();
        }
        public void cadastrarQuantidadeRodas()
        {
            Console.WriteLine($"Informe a Quantidade de Rodas do Veículo: ");
            this.automovel.quantidadeRodas = Convert.ToInt32(Console.ReadLine());
        }

        public void apresentarCadastro()
        {
            Console.WriteLine($"Nome: {this.cliente.Nome}");
            Console.WriteLine($"Sobrenome: {this.cliente.Sobrenome}");
            Console.WriteLine($"CPF: {this.cliente.CPF}");
            Console.WriteLine($"Placa do Veículo: {this.cliente.CPF}");
        }
    }
}