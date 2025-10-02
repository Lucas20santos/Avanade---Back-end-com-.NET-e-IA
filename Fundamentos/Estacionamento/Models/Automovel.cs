namespace Estacionamento.Models
{
    class Automovel
    {
        public string? modelo { get; set; }
        public string? marca { get; set; }
        public string? cor { get; set; }
        public string? placa { get; set; }
        public int quantidadeRodas { get; set; }

        public void pegarModelo(string? modelo)
        {

            this.modelo = modelo;
        }

        public void pegarMarca(string? marca)
        {

            this.marca = marca;
        }
        public void pegarCor(string? cor)
        {

            this.cor = cor;
        }
        public void pegarPlaca(string? placa)
        {
            this.placa = placa;
        }
        public void pegarQuantidadeRodas(int quantidadeRodas)
        {
            this.quantidadeRodas = quantidadeRodas;
        }
    }
}
