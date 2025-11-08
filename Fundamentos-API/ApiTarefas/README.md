# Api de tarefa

## Sumário

- Estrutura do projeto (árvore)
- Visão rápida
- Primeiro Passos
- Estrutura do projeto (árvore)
- Arquivos auxiliares fora do projeto ApiTarefaMVC

## Estrutura do projeto (árvore)

Abaixo está uma árvore representativa da pasta ApiTarefa. Ajuste conforme arquivos reais do seu workspace.

```md
ApiTarefas/
├─ MinhasTarefas/
│  ├─ MinhasTarefas.csproj
│  ├─ Program.cs
│  ├─ appsettings.json
│  ├─ appsettings.Development.json
|  ├─ bin/
|  |  └─ Debug/
|  |     └─ net8.0/
|  ├─ Context/
|  |  └─ TarefaContext.cs
│  ├─ Controllers/
│  │  └─ TarefaController.cs
│  ├─ Models/
│  │  └─ Tarefa.cs
│  ├─ Migrations/
│  │  └─ [arquivos de migration...]
│  ├─ Properties/
|
├─ DescricaoDoProjeto.md
├─ README.md
├─ .gitignore
├─ .vscode/
│  └─ settings.json
└─ docker-compose.yml (opcional)
```

---

## Visão rápida

Projeto exemplo de uma Web Api para gerenciar tarefas (CRUD) usado na trilha .NET. Contém endpoints para criar, ler, atualizar e deletar tarefas e exemplos para rodar com Docker / SQL Server.

## Primeiros Passos

1. Criando um projeto webapi no dotnet:
   - dotnet new webapi -n MinhasTarefas
2. Rodar o projeto MinhasTarefas:
   - dotnet run
3. Rodando o container sqlServer:
   - Dando stop caso ele esteja rodando:
     - docker stop Id ou nome do container
   - Excluindo containe antigo:
     - docker rm Id ou nome do container
   - Baixando a imagem do sqlServer caso não tenha:
     - docker pull mcr.microsoft.com/mssql/server:2025-latest
   - Criação do container e um usuario:
     - docker run -d --name mssql_tarefas -p 1433:1433 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SuaSenhaForte123!' mcr.microsoft.com/mssql/server:2025-latest
   - docker start mssql
4. Instalação das ferramentas necessárias para usar com o Entity Framework:
   - dotnet add package Microsoft.EntityFrameworkCore.SqlServer
     - Microsoft.EntityFrameworkCore.SqlServer: Permite que o EF Core se comunique com o SQL Server (seu container Docker).
   - dotnet add package Microsoft.EntityFrameworkCore.Design
     - Microsoft.EntityFrameworkCore.Design: É necessário para rodar comandos como dotnet ef migrations no terminal.

---

## Segundo Passos

- Criação da classe Tarefa.cs dentro da pasta modelo

```cs
namespace MinhasTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descicao { get; set; }
        public DateTime Date { get; set; }
        public StatusTarefa Status { get; set; }
    }
}

```

- Classe Enum para enumerar o status da tarefa

```cs
   namespace ApiTarefaMVC.Models 
   { 
      public enum StatusTarefa 
      { 
         Pendente, 
         EmAndamento, 
         Concluida 
      } 
   }
```

## Terceiro Passo

- O DbContext é a ponte entre sua aplicação .NET e o banco de dados, usando o Entity Framework Core (EF Core).

```cs
   using Microsoft.EntityFrameworkCore;
   using MinhasTarefas.Models;

   namespace MinhasTarefas.Context
   {
      public class TarefasContext : DbContext
      {
         // Contrutor que recebe as opções do DbContext
         public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) { }

         public DbSet<Tarefa> Tarefas { get; set; } = null!;      
      }
   }

```

- Configurando a Conexão: Definir o ConectionString no arquivo appsettings.Development.json caso o projeto não seja para produção e sim só desenvolvimento ou caso contrário mude o appsettings.json
- Configurar a Injeção de Dependência no Program.cs
   1. Precisamos dizer ao ASP.NET Core que use essa string de Conexão para configurar o DbContext
   2. No arquivo Program.cs

```cs
   using Microsoft.EntityFrameworkCore;
   using MinhasTarefas.Context;
   using MinhasTarefas.Models;

   var builder = WebApplication.CreateBuilder(args);

   builder.Services.AddDbContext<OrganizadorContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
   );

   builder.Services.AddControllers();
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen();

   var app = builder.Build();

   if (app.Environment.IsDevelopment())
   {
      app.UseSwagger();
      app.UseSwaggerUI();
   }

   app.UseHttpsRedirection();

   var summaries = new[]
   {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
   };

   app.MapGet("/weatherforecast", () =>
   {
      var forecast =  Enumerable.Range(1, 5).Select(index =>
         new WeatherForecast
         (
               DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
               Random.Shared.Next(-20, 55),
               summaries[Random.Shared.Next(summaries.Length)]
         ))
         .ToArray();
      return forecast;
   })
   .WithName("GetWeatherForecast")
   .WithOpenApi();

   app.Run();

   record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
   {
      public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
   }
```

## Quarto Passo - Configurando o arquivo appsettings.Development.json

```json
   {
      "Logging": {
         "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
         }
      },
      "ConnectionStrings": {
         "ConexaoPadrao": "Server=localhost,1433; Initial Catalog=Tarefa; User Id=sa; Password=SuaSenhaForte123!; TrustServerCertificate=True; MultipleActiveResultSets=True"
      }
   }
```

## Quinto Passo - Criando as migrations

### comando dotnet ef

```bash
   dotnet build # vode primeiro e veja se tem algum problema, caso não tenha, agora rode o sequinte comando:
   dotnet ef migrations add InitialCreate
   dotnet ef database update
```
