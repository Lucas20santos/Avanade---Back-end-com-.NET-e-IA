namespace Estacionamento.Models
{
    class Pagamento
    {
        Menu menu = new Menu();
        Custo custo = new Custo();
        public void Pix()
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }

        public void Dinheiro()
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }
        public void cartaoDeCredito()
        {
            menu.apresentarFormaDePagamentoCartaoDeCredito();

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
            }
        }
    }
}