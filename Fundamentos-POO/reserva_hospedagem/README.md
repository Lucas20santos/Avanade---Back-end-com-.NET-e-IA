# 🏨 Projeto Reserva de Hospedagem

Bem-vindo ao **Projeto Reserva de Hospedagem**!  
Este sistema simula reservas em hotéis, permitindo o cadastro de hóspedes, suítes e o cálculo do valor total da estadia de forma simples e intuitiva.

---

## ✨ Funcionalidades

- 👤 **Cadastro de Hóspedes**: Nome e sobrenome.
- 🛏️ **Cadastro de Suítes**: Tipo, capacidade e valor da diária.
- 📅 **Criação de Reservas**: Associação de hóspedes e suítes.
- 💰 **Cálculo de Valor Total**: Baseado nos dias reservados.
- 🔢 **Consulta de Hóspedes**: Quantidade de hóspedes por reserva.

---

## 🛠️ Tecnologias Utilizadas

- ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
- ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
- Programação Orientada a Objetos (POO)

---

## 🗂️ Estrutura de Classes

| Classe  | Descrição | Principais Propriedades/Métodos |
|---------|-----------|---------------------------------|
| [`Pessoa`](Models/Pessoa.cs) 👤 | Representa um hóspede | Nome, Sobrenome |
| [`Suite`](Models/Suite.cs) 🛏️ | Representa uma suíte | TipoDeSuite, Capacidade, ValorDiario |
| [`Reserva`](Models/Reserva.cs) 📅 | Gerencia reservas | Lista de hóspedes, suíte, dias de reserva, métodos de cadastro e cálculo |

---

## 🚀 Exemplo de Uso

```csharp
using reserva_hospedagem.Models;

Pessoa p1 = new Pessoa(nome:"Lucas", sobrenome:"De Souza Santos");
Suite s1 = new Suite(tiposuite: "Solteiro", capacidade: 1, valor_diario: 50);

Reserva r1 = new Reserva(suite: s1, diasdereserva: 7);
r1.CadastrarHospedes(p1);
r1.CadastrarSuite(s1);

Console.WriteLine(r1.ObterQuantidadeHospedes());
Console.WriteLine(r1.CalcularValorHospedagem(s1));
```

---

## ▶️ Como Executar

1. Clone o repositório:

   ```sh
   git clone <url-do-repositorio>
   ```

2. Acesse a pasta do projeto:

   ```sh
   cd Avanade---Back-end-com-.NET-e-IA/Fundamentos-POO/reserva_hospedagem
   ```

3. Execute o projeto:

   ```sh
   dotnet run
   ```

Se quiser, personalize ainda mais com GIFs, imagens ou links para seu perfil!
