using Estacionamento.Models;
using Fundation.Models;

namespace Estacionamento.Models
{
    class Estacionamentos
    {
        Cadastro cadastro = new Cadastro();
        Historico historico = new Historico();
        private List<string> veiculos = new List<string>();
        public void cadastrarCliente(Cliente cliente)
        {
            cadastro.cadastrarNome(cliente);
            cadastro.cadastrarSobrenome(cliente);
            cadastro.cadastrarCPF(cliente);
        }
        public void cadastrarAutomovel(Automovel automovel)
        {
            cadastro.cadastrarModelo(automovel);
            cadastro.cadastrarMarca(automovel);
            cadastro.cadastrarCor(automovel);
            cadastro.cadastrarQuantidadeRodas(automovel);
        }
        public void historicoEntrada(Cliente cliente, Automovel automovel)
        {
            historico.atualizarHistoricoEntrada(cliente, automovel);
        }
        public void historicoSaida(Cliente cliente, Automovel automovel)
        {
            historico.atualizarHistoricoSaida(cliente, automovel);
        }
        public void adicionarAutomovel(Cliente cliente, Automovel automovel)
        {
            cadastro.AdicionarVeiculo(cliente, automovel);
        }
        public void removerVeiculo(Cliente cliente, Automovel automovel)
        {
            cadastro.RemoverVeiculo(cliente, automovel);
        }
        public void mostrarVeiculos(Cliente cliente, Automovel automovel)
        {
            cadastro.ListarVeiculos(cliente, automovel);
        }
    }
}
