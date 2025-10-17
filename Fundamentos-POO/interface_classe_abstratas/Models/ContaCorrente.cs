namespace interface_classe_abstratas.Models
{
    class ContaCorrente : Conta
    {
        public override void Creditar(double valor)
        {
            saldo += valor;
        }
    }
}