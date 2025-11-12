# Testes unitários com Csharp

## O que é um teste \?

Existem vários tipos de testes de software: uinitários, integraçãi, regressivo, segurança, etc

Os testes são fundamentais para garantir a qualidade e o correto funcionamento e um software.

Serve principalmente para validar se o que foi construído está atendendo ao que se é esperado.

## O que é um teste unitário ?

Teste unitário (ou teste de unidade) são testes realizados diretemnte no código fonte, buscando testar a menor unidade de código possível, através de cenários que podem ocorrer no sistema.

### Exemplo```:```

Um usuário do sistema só é cadastrado se possuir um CPF e um e-mail válido. Caso contário, retornará um erro indicando o que está errado.

### Possíveis casos de testes

- Usuário com todos os dados válidos
- Usuário com CPF inválido
- Usuário com e-mail inválido

## Vantagens

- A maior vantagem é a **qualidade**.
- Garantir que a alteração não tenha impactos no sistema.
- Menos bugs.
- Maior confiança de que suas classes e métodos funcionam.
- Prevenir problemas futuros.

## Framework de testes

- MSTest
- NUnit
- **xUnit**

### Arquitetura do Projeto

- Solution
  - Calculadora
  - CalculadoraTests

## Projeto

```bash
    dotnet new console -n Calculadora
    dotnet new xunit -n CalculadoraTests

    # Criando uma solution
    dotnet new sln -n CalculadoraSolution

    # Adicionando os projetos na solution
    dotnet sln add Calculadora/Calculadora.csproj
    dotnet sln add CalculadoraTests/CalculadoraTests.csproj
```
