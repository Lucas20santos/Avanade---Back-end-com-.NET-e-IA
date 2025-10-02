namespace Estacionamento.Models
{
    class Pagamento
    {
        public void Pix(Custo custo)
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }

        public void Dinheiro(Custo custo)
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }
        public void cartaoDeCredito(Custo custo)
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }
        public void cartaoDeDebito(Custo custo)
        {
            Console.WriteLine($"Pagamento de {custo.precoDoAluguel} realizado com sucesso.");
        }
    }
}