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
