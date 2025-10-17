namespace interface_classe_abstratas.Models
{
    public abstract class Conta
    {
        protected double saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }
        
    }
}