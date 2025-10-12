using reserva_hospedagem.Models;

// Primeira reserva
Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "De Souza Santos");
Suite s1 = new Suite(tipoSuite: TipoSuite.Solteiro, capacidade: 1, valor_diario: 50);

Reserva r1 = new Reserva(suite: s1, diasDeReserva: 7);
r1.CadastrarHospedes(p1);
r1.CadastrarSuite(s1);
r1.apresentarHospedagem();

// Segunda reserva
Pessoa p2 = new Pessoa(nome: "Luiz", sobrenome: "Lima");
Pessoa p3 = new Pessoa(nome: "Marta", sobrenome: "Souza");

Suite s2 = new Suite(tipoSuite: TipoSuite.Casal, capacidade: 2, valor_diario: 100);

Reserva r2 = new Reserva(suite: s2, diasDeReserva: 4);
r2.CadastrarHospedes(p2);
r2.CadastrarHospedes(p3);
r2.CadastrarSuite(s2);
r2.apresentarHospedagem();

// Terceira reserva - Duplo
Pessoa p4 = new Pessoa(nome: "Ana", sobrenome: "Silva");
Pessoa p5 = new Pessoa(nome: "Carlos", sobrenome: "Pereira");

Suite s3 = new Suite(tipoSuite: TipoSuite.Duplo, capacidade: 2, valor_diario: 120);

Reserva r3 = new Reserva(suite: s3, diasDeReserva: 3);
r3.CadastrarHospedes(p4);
r3.CadastrarHospedes(p5);
r3.CadastrarSuite(s3);
r3.apresentarHospedagem();

// Quarta reserva - Luxo
Pessoa p6 = new Pessoa(nome: "Fernanda", sobrenome: "Almeida");

Suite s4 = new Suite(tipoSuite: TipoSuite.Luxo, capacidade: 1, valor_diario: 200);

Reserva r4 = new Reserva(suite: s4, diasDeReserva: 2);
r4.CadastrarHospedes(p6);
r4.CadastrarSuite(s4);
r4.apresentarHospedagem();

// Quinta reserva - Master
Pessoa p7 = new Pessoa(nome: "Bruno", sobrenome: "Costa");
Pessoa p8 = new Pessoa(nome: "Patrícia", sobrenome: "Ramos");

Suite s5 = new Suite(tipoSuite: TipoSuite.Master, capacidade: 2, valor_diario: 300);

Reserva r5 = new Reserva(suite: s5, diasDeReserva: 5);
r5.CadastrarHospedes(p7);
r5.CadastrarHospedes(p8);
r5.CadastrarSuite(s5);
r5.apresentarHospedagem();

// Sexta reserva - Presidencial
Pessoa p9 = new Pessoa(nome: "João", sobrenome: "Barros");

Suite s6 = new Suite(tipoSuite: TipoSuite.Presidencial, capacidade: 10, valor_diario: 500);

Reserva r6 = new Reserva(suite: s6, diasDeReserva: 1);
r6.CadastrarHospedes(p9);
r6.CadastrarSuite(s6);
r6.apresentarHospedagem();

// Sétima reserva - Família
Pessoa p10 = new Pessoa(nome: "Mariana", sobrenome: "Oliveira");
Pessoa p11 = new Pessoa(nome: "Pedro", sobrenome: "Oliveira");
Pessoa p12 = new Pessoa(nome: "Lucas", sobrenome: "Oliveira");

Suite s7 = new Suite(tipoSuite: TipoSuite.Familia, capacidade: 10, valor_diario: 250);

Reserva r7 = new Reserva(suite: s7, diasDeReserva: 6);
r7.CadastrarHospedes(p10);
r7.CadastrarHospedes(p11);
r7.CadastrarHospedes(p12);
r7.CadastrarSuite(s7);
r7.apresentarHospedagem();
