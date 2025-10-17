using interface_classe_abstratas.Models;


// Exemplo para herança
Aluno a1 = new Aluno("Lucas", 12);

a1.nota = 10;
a1.apresentar();

Professor p1 = new Professor("Marcos", 55);

p1.salario = 1234.45;
p1.apresentar();

// Exemplo para Classe Abstratas

ContaCorrente cc = new ContaCorrente();

cc.Creditar(500);
cc.ExibirSaldo();
