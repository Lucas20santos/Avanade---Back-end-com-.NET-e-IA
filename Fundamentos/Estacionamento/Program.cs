using Estacionamento.Models;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (true)
            {
                Estacionamentos estacionamento = new Estacionamentos();
                Cliente cliente = new Cliente();
                Automovel automovel = new Automovel();

                Console.WriteLine("Cadastro De Cliente: ");

                estacionamento.cadastrarCliente(cliente);
                estacionamento.cadastrarAutomovel(automovel);

                menu.apresentar();

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao != 4)
                {
                    switch (opcao)
                    {
                        case 1:
                            estacionamento.AdicionarVeiculo("");
                            break;
                        case 2:
                            estacionamento.RemoverVeiculo();
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
