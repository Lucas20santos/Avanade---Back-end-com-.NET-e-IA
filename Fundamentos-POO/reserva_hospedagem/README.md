# 🏨 Projeto Reserva de Hospedagem

![Banner do Projeto](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExd2F2Z3F6b2N6b3F6d3J5d3F2d3F6d3F6d3F6d3F6d3F6d3F6/giphy.gif)

Bem-vindo ao **Projeto Reserva de Hospedagem**!  
Este sistema simula reservas em hotéis, permitindo o cadastro de hóspedes, suítes e o cálculo do valor total da estadia de forma simples e intuitiva.

---

## 👤 Sobre o Autor

Desenvolvido por [Seu Nome](https://www.linkedin.com/in/seu-perfil/)  
[![GitHub](https://img.shields.io/badge/GitHub-Perfil-181717?style=flat&logo=github&logoColor=white)](https://github.com/seu-usuario)

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

---

## 💡 Melhorias Sugeridas

- 🔒 **Validação de Dados**: Adicionar validações para evitar cadastro de hóspedes ou suítes com informações incompletas ou inválidas.
- 🖥️ **Interface Gráfica**: Criar uma interface web ou desktop para facilitar o uso do sistema.
- 🗃️ **Persistência de Dados**: Implementar armazenamento em banco de dados (ex: SQLite, SQL Server) para manter registros entre execuções.
- 📈 **Relatórios**: Gerar relatórios de reservas, ocupação e faturamento.
- 🌐 **API REST**: Disponibilizar as funcionalidades via API para integração com outros sistemas.
- 🧪 **Testes Automatizados**: Adicionar testes unitários e de integração para garantir a qualidade do código.
- 🌍 **Internacionalização**: Suporte a múltiplos idiomas.
- 📝 **Documentação Técnica**: Detalhar endpoints, exemplos de uso e arquitetura do projeto.
- 👥 **Cadastro de Usuários/Administração**: Permitir diferentes níveis de acesso e autenticação.
- 📅 **Gestão de Disponibilidade**: Implementar controle de disponibilidade de suítes por período.
- 💸 **Política de Descontos**: Adicionar regras de desconto para reservas longas ou promoções.

---

> _Gostou do projeto? Me adicione no [LinkedIn](https://www.linkedin.com/in/lucas-de-santos-souza/) e confira outros trabalhos no [GitHub](https://github.com/Lucas20santos)!_
