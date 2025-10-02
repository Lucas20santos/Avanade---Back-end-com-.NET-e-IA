using Estacionamento.Models;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Estacionamentos estacionamento = new Estacionamentos();
            Custo custo = new Custo();
            Cliente cliente = new Cliente();
            Historico historico = new Historico();
            Pagamento pagamento = new Pagamento();

            while (true)
            {
                menu.apresentar();
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao != 4)
                {
                    switch (opcao)
                    {
                        case 1:
                            // Cadastrar Cliente: uma melhor prática seria ter um classe para cadastrar todas as informações.
                            Console.Write("Qual é o seu nome: ");
                            cliente.Nome = Console.ReadLine();
                            Console.Write("Qual é o seu sobrenome: ");
                            cliente.Sobrenome = Console.ReadLine();
                            Console.Write("Qual é o seu CPF: ");
                            cliente.CPF = Console.ReadLine();
                            Console.Write("Informe a placa do veiculo: ");

                            string? placa = Console.ReadLine();
                            estacionamento.AdicionarVeiculo(placa);

                            historico.atualizarHistoricoEntrada(cliente.Nome, cliente.Sobrenome, cliente.CPF, estacionamento.placaVeiculo);
                            break;
                        case 2:
                            Console.Write("Qual é o seu nome: ");
                            cliente.Nome = Console.ReadLine();
                            Console.Write("Qual é o seu sobrenome: ");
                            cliente.Sobrenome = Console.ReadLine();
                            Console.Write("Qual é o seu CPF: ");
                            cliente.CPF = Console.ReadLine();
                            Console.Write("Informe a placa do veiculo: ");

                            estacionamento.RemoverVeiculo();

                            historico.atualizarHistoricoSaida(cliente.Nome, cliente.Sobrenome, cliente.CPF, estacionamento.placaVeiculo);
                            break;
                        case 3:

                            estacionamento.ListarVeiculos();

                            break;
                        default:
                            Console.WriteLine("Valor Informando não consta no Menu.");
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
