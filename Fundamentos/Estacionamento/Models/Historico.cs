namespace Estacionamento.Models
{
    class Historico
    {
        public List<string> historicoEntrada = new List<string>();
        public List<string> historicoSaida = new List<string>();

        public void atualizarHistoricoEntrada(string? nome, string? sobrenome, string? cpf, string? placa)
        {
            if (!string.IsNullOrWhiteSpace(nome)) this.historicoEntrada.Add(nome); else Console.WriteLine("Por favor inserir o nome");
            if (!string.IsNullOrWhiteSpace(sobrenome)) this.historicoEntrada.Add(sobrenome); else Console.WriteLine("Por favor inserir o sobrenome");
            if (!string.IsNullOrWhiteSpace(cpf)) this.historicoEntrada.Add(cpf); else Console.WriteLine("Por favor inserir o cpf");
            if (!string.IsNullOrWhiteSpace(placa)) this.historicoEntrada.Add(placa); else Console.WriteLine("Por favor inserir a placa do veiculo");
        }

        public void atualizarHistoricoSaida(string? nome, string? sobrenome, string? cpf, string? placa)
        {
            if (!string.IsNullOrWhiteSpace(nome)) this.historicoSaida.Add(nome); else Console.WriteLine("Por favor inserir o nome");
            if (!string.IsNullOrWhiteSpace(sobrenome)) this.historicoSaida.Add(sobrenome); else Console.WriteLine("Por favor inserir o sobrenome");
            if (!string.IsNullOrWhiteSpace(cpf)) this.historicoSaida.Add(cpf); else Console.WriteLine("Por favor inserir o cpf");
            if (!string.IsNullOrWhiteSpace(placa)) this.historicoSaida.Add(placa); else Console.WriteLine("Por favor inserir a placa do veiculo");
        }

        public void mostrarHistoricoEntrada()
        {
            for (int i = 0; i < historicoEntrada.Count; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"Nome: {historicoEntrada[i]}");
                }
                else if (i % 4 == 1)
                {
                    Console.WriteLine($"Sobrenome: {historicoEntrada[i]}");
                }
                else if (i % 4 == 2)
                {
                    Console.WriteLine($"CPF: {historicoEntrada[i]}");
                }
                else
                {
                    Console.WriteLine($"Sobrenome: {historicoEntrada[i]}");
                }
            }

        }

        public void mostrarHistoricoSaida()
        {
            for (int i = 0; i < historicoEntrada.Count; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"Nome: {historicoEntrada[i]}");
                }
                else if (i % 4 == 1)
                {
                    Console.WriteLine($"Sobrenome: {historicoEntrada[i]}");
                }
                else if (i % 4 == 2)
                {
                    Console.WriteLine($"CPF: {historicoEntrada[i]}");
                }
                else
                {
                    Console.WriteLine($"Sobrenome: {historicoEntrada[i]}");
                }
            }
        }
    }
}
