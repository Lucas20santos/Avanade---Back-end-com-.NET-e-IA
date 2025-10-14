# Herança e Polimorfismo

## Codigo

```cs
using System;

namespace MyCompiler 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Aluno a1 = new Aluno();
            a1.nome = "Lucas";
            a1.idade = 12;
            a1.nota = 10;
            a1.apresentar();

            Professor p1 = new Professor();
            p1.nome = "Marcos";
            p1.idade = 55;
            p1.salario = 1234.45;
            p1.apresentar();
        }
    }
    class Pessoa
    {
        public string nome;
        public int idade;

        public virtual void apresentar()
        {
            Console.WriteLine($"A pessoa, {nome} de {idade} anos.");
        }        
    }

    class Aluno : Pessoa
    {
        public double nota;
        
        public override void apresentar()
        {
            Console.WriteLine($"O aluno, {nome} de {idade} anos e tenho nota {nota}.");
        }
    }

    class Professor : Pessoa
    {
        public double salario;

        public override void apresentar()
        {
            Console.WriteLine($"O professor {nome} de {idade} anos e tenho salario {salario}.");
        }
    }
}
```
