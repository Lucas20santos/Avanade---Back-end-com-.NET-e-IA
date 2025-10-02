using Estacionamento.Models;

namespace Fundation.Models
{
    class Cadastro
    {
        Automovel automovel = new Automovel();

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
        public void cadastrarPlaca()
        {
            Console.Write($"Informe a Placa do Veículo: ");
            this.automovel.placa = Console.ReadLine();
        }
        public void cadastrarModelo()
        {
            Console.Write($"Informe o Modelo do Veículo: ");
            this.automovel.modelo = Console.ReadLine();
        }
        public void cadastrarCor()
        {
            Console.Write($"Informe a Cor do Veículo: ");
            this.automovel.cor = Console.ReadLine();
        }
        public void cadastrarMarca()
        {
            Console.Write($"Informe a Marca do Veículo: ");
            this.automovel.marca = Console.ReadLine();
        }
        public void cadastrarQuantidadeRodas()
        {
            Console.Write($"Informe a Quantidade de Rodas do Veículo: ");
            this.automovel.quantidadeRodas = Convert.ToInt32(Console.ReadLine());
        }

        public void apresentarCadastro(Cliente cliente)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Sobrenome: {cliente.Sobrenome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Placa do Veículo: {cliente.CPF}");
        }
    }
}