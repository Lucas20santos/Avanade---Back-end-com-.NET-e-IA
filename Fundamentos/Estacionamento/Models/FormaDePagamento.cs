namespace Estacionamento.Models
{
    class FormaDePagamento
    {
        public decimal valor;

        public void Pix()
        {
            Console.WriteLine($"Pagamento de {this.valor} realizado com sucesso.");
        }

        public void Dinheiro()
        {
            Console.WriteLine("Pagamento realizado com sucesso.");
        }
        public void cartaoDeCredito()
        {
            Console.WriteLine("[1] Debito\n[2] Credito ?");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Pagamento realizado no Debito com sucesso.");
            }
            else
            {
                Console.WriteLine("Pagamento realizado no Credito com sucesso.");
            }
        }
    }
}