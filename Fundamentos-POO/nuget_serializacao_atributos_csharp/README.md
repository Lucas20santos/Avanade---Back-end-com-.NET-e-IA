# Nuget, Serialização e Atribuoos no Csharp

## Introdução ao gerenciador de Pacotes

O Nuget é o gerenciador de pacotes do dotnet

## Instalando um pacote no dotnet

```dotnet
    dotnet add package Newtonsoft.Json --version 13.0.4
```

```xml
    <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net8.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
    </PropertyGroup>
    <!-- Incluiu essa tag abaixo -->
    <ItemGroup>
        <PackageReference Include="Newtonsoft.Json" Version="13.0.4" />
    </ItemGroup>

    </Project>
```

## Serializando um objeto no dotnet

```cs
    using nuget_serializacao_atributo_csharp.Models;
    using Newtonsoft.Json;

    List<Pessoa> listaPessoa = new List<Pessoa>();

    Pessoa p1 = new Pessoa();
    p1.Nome = "Lucas";
    p1.Sobrenome = "Santos";
    p1.idade = 33;
    p1.apresentar();

    Pessoa p2 = new()
    {
        Nome = "Maria",
        Sobrenome = "Santos",
        idade = 34
    };

    listaPessoa.Add(p1);
    listaPessoa.Add(p2);

    string serializacao = JsonConvert.SerializeObject(listaPessoa, Formatting.Indented);
    File.WriteAllText("lista_pessoa.json", serializacao);
```
