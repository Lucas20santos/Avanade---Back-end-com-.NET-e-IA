using reserva_hospedagem.Models;

Pessoa p1 = new Pessoa(nome:"Lucas", sobrenome:"De Souza Santos");
Suite s1 = new Suite(tiposuite: "Solteiro", capacidade: 1, valor_diario: 50);

Reserva r1 = new Reserva(suite: s1, diasdereserva: 7);
r1.CadastrarHospedes(p1);
r1.CadastrarSuite(s1);
Console.WriteLine(r1.ObterQuantidadeHospedes());
