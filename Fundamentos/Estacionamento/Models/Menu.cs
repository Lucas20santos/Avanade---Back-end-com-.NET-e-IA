namespace Estacionamento.Models
{
    class Menu
    {

        public void apresentar()
        {
            Console.WriteLine("1 - Adicionar Veiculo");
            Console.WriteLine("2 - Remover Veiculo");
            Console.WriteLine("3 - Listar Veiculos");
            Console.WriteLine("4 - Encerrar");
        }
    }    
}