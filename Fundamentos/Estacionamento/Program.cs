using Estacionamento.Models;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja Bem-Vindo EstacionaBEM");
            Menu m1 = new Menu();
            Estacionamentos e1 = new Estacionamentos();
            Custo c1 = new Custo();

            while (true)
            {
                m1.apresentar();
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        e1.AdicionarVeiculo();
                        break;
                    case 2:
                        e1.RemoverVeiculo();
                        break;
                    case 3:
                        e1.ListarVeiculos();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Valor Informando não consta no Menu.");
                        break;
                }
                break;
            }
        }
    }
}
