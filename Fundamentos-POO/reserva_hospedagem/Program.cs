using reserva_hospedagem.Models;

Pessoa p1 = new Pessoa(nome:"Lucas", sobrenome:"De Souza Santos");
Suite s1 = new Suite(tiposuite: "Solteiro", capacidade: 1, valor_diario: 50);

Pessoa p2 = new Pessoa(nome: "Luiz", sobrenome: "Lima");
Pessoa p3 = new Pessoa(nome: "Marta", sobrenome: "Souza");

Suite s2 = new Suite(tiposuite: "Casal", capacidade: 2, valor_diario: 100);

Reserva r1 = new Reserva(diasdereserva: 7);
r1.CadastrarHospedes(p1);
r1.CadastrarSuite(s1);
Console.WriteLine(r1.ObterQuantidadeHospedes());

Reserva r2 = new Reserva(diasdereserva: 4);
r2.CadastrarHospedes(p2);
r2.CadastrarHospedes(p3);
r2.CadastrarSuite(s2);
Console.WriteLine(r2.CalcularValorHospedagem(suite: s2));
