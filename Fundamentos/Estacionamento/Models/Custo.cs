namespace Estacionamento.Models
{
    class Custo
    {
        public decimal PRECOFIXO { get; set; }
        public decimal PRECOPORHORA { get; set; }

        public decimal CalculoDoEstacionamento(decimal horas)
        {
            return this.PRECOFIXO + this.PRECOPORHORA * horas;
        }

        public void FixarPrecosDoAluguel(decimal fixo, decimal porHora)
        {
            this.PRECOFIXO = fixo;
            this.PRECOPORHORA = porHora;
        }
    }
}