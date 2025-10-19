# Funadmentos API

## Comandos básicos para criação de projeto

### Crianção de uma solution

```cs
    dotnet new sln -n "nome da solution"
```

### Criação de um projeto console

```cs
    dotnet new console -n "nome-do-projeto"
```

### Adiconando o projeto console a solution

```cs
    dotnet sln add "nome-do-projeto/nome-do-projeto.csproj"
```

### Adicionar as referencias de projeto em outros projeto

Assim você conseque que vários projetos consigam se enxergar

```cs
    dotnet add "nome-do-projeto/nome-do-projeto.csproj" reference "nome-de-outro-projeto/nome-de-outro-projeto.csproj"
```

Vocẽ está pedindo que o dotnet adicione as referencias do outro projeto "nome-de-outro-projeto" no seu projeto principal.
