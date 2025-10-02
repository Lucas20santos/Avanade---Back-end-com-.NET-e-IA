namespace Estacionamento.Models
{
    class Custo
    {
        public decimal PRECOFIXO { get; set; }
        public decimal PRECOPORHORA { get; set; }
        public decimal precoDoAluguel { get; set; }

        public decimal CalculoDoEstacionamento(decimal horas)
        {
            this.precoDoAluguel = this.PRECOFIXO + this.PRECOPORHORA * horas;

            return this.precoDoAluguel;
        }

        public void FixarPrecosFixo(decimal fixo)
        {
            this.PRECOFIXO = fixo;
        }

        public void fixarPrecoPorHora(decimal precoPorHora)
        {
            this.PRECOPORHORA = precoPorHora;
        }
    }
}