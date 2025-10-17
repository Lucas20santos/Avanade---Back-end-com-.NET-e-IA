# 🧭 Interfaces & Classes Abstratas

Breve guia e exemplos do conteúdo presente na pasta "interface_classe_abstratas".  
Contém exemplos de herança, polimorfismo (virtual/override) e organização de classes simples em C#.

---

## ✨ Temas abordados

- 🔁 Herança (classe base -> classes derivadas)  
- 🔧 Polimorfismo com `virtual` / `override`  
- 🧩 Diferença entre classes concretas, abstratas e `sealed` (breve explicação)  
- 🧰 Estrutura simples de classes (Pessoa, Aluno, Professor) e uso em `Program.cs`

---

## 📚 Resumo das classes

- Pessoa (base)
  - Responsabilidade: representar uma pessoa genérica.
  - Membros principais: `nome`, `idade`, método `apresentar()` marcado como `virtual` (permite sobrescrita).
  - Observação: pode ser transformada em `abstract` se você não quiser instanciá-la diretamente.

- Aluno (herda Pessoa)
  - Responsabilidade: representar um aluno com `nota`.
  - Sobrescreve `apresentar()` usando `override` para exibir informação específica do aluno.

- Professor (herda Pessoa)
  - Responsabilidade: representar um professor com `salario`.
  - Sobrescreve `apresentar()` usando `override`.
  - Pode ser marcada como `sealed` para impedir novas derivações, quando fizer sentido.

---

## 📝 Diferenças rápidas

- Classe abstrata (`abstract class`): define contrato/estrutura e pode ter membros abstratos; não pode ser instanciada.
- Interface (`interface`): contrato puro (sem estado), implementada por classes; multiple inheritance.
- `virtual` / `override`: permite que uma classe base forneça uma implementação que classes filhas alterem.
- `sealed`: impede que a classe seja herdada.

---

## 🚀 Código de exemplo (completo)

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

        // Permite que classes derivadas sobrescrevam este comportamento
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

---

## ▶️ Como executar

1. Abra o terminal na pasta do projeto:

```sh
   cd interface_classe_abstratas
```

1. Compile e execute:

   ```sh
   dotnet run
   ```

---

## ✅ Boas práticas / próximos passos sugeridos

- Transformar `Pessoa` em `abstract` se não for instanciada diretamente.  
- Usar propriedades (`Nome`, `Idade`) em vez de campos públicos.  
- Validar dados (nome não nulo, idade não negativa).  
- Criar interfaces quando houver múltiplos comportamentos reutilizáveis (ex.: `ITrabalhador` com salário).  
- Escrever testes unitários simples para `apresentar()`.

---

Feito para facilitar estudo e apresentação — use este README como ponto de partida para evoluir as classes e aplicar validações e padrões.
