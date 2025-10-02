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
        public void cadastrarAutomovel()
        {
            Console.WriteLine($"Informe a Placa do Veículo: ");
            this.automovel.placa = Console.ReadLine();
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