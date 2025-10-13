namespace reserva_hospedagem.Models
{
    class Reserva
    {
        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite;
        private int _diasDeReservas;

        public IReadOnlyList<Pessoa> Hospedes => _hospedes.AsReadOnly();
        public Suite Suite => _suite;
        public int DiasDeReserva => _diasDeReservas;

        public Reserva() { }
        public Reserva(Suite suite, int diasDeReserva)
        {
            if (diasDeReserva < 1)
                throw new ArgumentException("Dias de reserva deve ser maior que zero.");
            _suite = suite ?? throw new ArgumentException(nameof(suite));
            _diasDeReservas = diasDeReserva;
        }

        public void CadastrarHospedes(Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa));
            if (_suite != null && _hospedes.Count >= _suite.Capacidade)
                throw new ArgumentException("Capacidade máxima da suite atingida. Escolha outro tipo de suite");
            _hospedes.Add(pessoa);
        }

        public void CadastrarSuite(Suite suite)
        {
            this._suite = suite ?? throw new ArgumentNullException(nameof(suite));
        }

        public int ObterQuantidadeHospedes() => _hospedes.Count;

        public decimal CalcularValorHospedagem()
        {
            if (_suite == null)
                throw new InvalidOperationException("Suite não cadastrada.");
            if (_diasDeReservas < 1)
                throw new InvalidOperationException("Dias de reserva deve ser maior que zero.");
            if (_hospedes.Count == 0)
                throw new InvalidOperationException("Nenhum hóspede cadastrado.");

            return _hospedes.Count >= 10
                ? _diasDeReservas * _suite.ValorDiario
                : (decimal)0.9 * _diasDeReservas * _suite.ValorDiario;
        }

        public void apresentarHospedagem()
        {
            if (_suite == null)
            {
                Console.WriteLine("Nenhuma suíte cadastrada para esta reserva.");
                return;
            }

            Console.WriteLine("===== Detalhes da Hospedagem =====");
            Console.WriteLine($"Suíte: {_suite.TipoSuite}");
            Console.WriteLine($"Capacidade da suíte: {_suite.Capacidade}");
            Console.WriteLine($"Valor da diária: R$ {_suite.ValorDiario:F2}");
            Console.WriteLine($"Dias reservados: {_diasDeReservas}");
            Console.WriteLine($"Quantidade de hóspedes: {_hospedes.Count}");

            Console.WriteLine("Hóspedes:");
            if (_hospedes.Count == 0)
            {
                Console.WriteLine("Nenhum hóspede cadastrado.");
            }
            else
            {
                foreach (var hospede in _hospedes)
                {
                    Console.WriteLine($"- {hospede.Nome} {hospede.Sobrenome}");
                }
            }

            Console.WriteLine($"Valor total da hospedagem: R$ {CalcularValorHospedagem():F2}");
            Console.WriteLine("==================================");
        }
    }
}