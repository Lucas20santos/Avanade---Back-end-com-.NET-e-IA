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

        public void apresetarFormaDePagamento()
        {
            Console.WriteLine("1 - Pix: ");
            Console.WriteLine("2 - Dinheiro: ");
            Console.WriteLine("3 - Cartão de Credito: ");
        }

        public void apresentarFormaDePagamentoCartaoDeCredito()
        {
            Console.WriteLine("[1] - Debito: ");
            Console.WriteLine("[2] - Credito: ");
        }
    }    
}