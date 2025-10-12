using reserva_hospedagem.Models;

// Primeira reserva

Pessoa p1 = new Pessoa(nome:"Lucas", sobrenome:"De Souza Santos");
Suite s1 = new Suite(tipoSuite: TipoSuite.Solteiro, capacidade: 1, valor_diario: 50);

Reserva r1 = new Reserva(suite: s1 ,diasDeReserva: 7);
r1.CadastrarHospedes(p1);
r1.CadastrarSuite(s1);
Console.WriteLine(r1.ObterQuantidadeHospedes());
Console.WriteLine(r1.CalcularValorHospedagem());

// segunda reserva

Pessoa p2 = new Pessoa(nome: "Luiz", sobrenome: "Lima");
Pessoa p3 = new Pessoa(nome: "Marta", sobrenome: "Souza");


Suite s2 = new Suite(tipoSuite: TipoSuite.Casal, capacidade: 2, valor_diario: 100);

Reserva r2 = new Reserva(suite: s2, diasDeReserva: 4);
r2.CadastrarHospedes(p2);
r2.CadastrarHospedes(p3);
r2.CadastrarSuite(s2);
Console.WriteLine(r2.ObterQuantidadeHospedes());
Console.WriteLine(r2.CalcularValorHospedagem());
