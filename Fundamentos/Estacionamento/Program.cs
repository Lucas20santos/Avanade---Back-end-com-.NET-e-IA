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
                            estacionamento.AdicionarVeiculo();
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
