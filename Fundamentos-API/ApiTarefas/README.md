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
├─ ApiTarefaMVC/
│  ├─ ApiTarefaMVC.csproj
│  ├─ Program.cs
│  ├─ Startup.cs                (se aplicável)
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
│  ├─ Data/
│  │  └─ TarefaContext.cs
│  ├─ Migrations/
│  │  └─ [arquivos de migration...]
│  ├─ Properties/
│  │  └─ launchSettings.json
│  └─ Views/                    (apenas se MVC completo)
├─ DescricaoDoProjeto.md
├─ README.md
├─ .gitignore
├─ .vscode/
│  └─ settings.json
└─ docker-compose.yml (opcional)
```

---

## Arquivos auxiliares (fora do ApiTarefaMVC)

- DescricaoDoProjeto.md — especificação do desafio e endpoints esperados.
- README.md — este arquivo (sumário inicial).
- .vscode/ — configurações do VS Code (preview, settings de workspace).
- .gitignore — regras de versionamento.

## Visão rápida

Projeto exemplo de API MVC para gerenciar tarefas (CRUD) usado na trilha .NET. Contém endpoints para criar, ler, atualizar e deletar tarefas e exemplos para rodar com Docker / SQL Server.

## Primeiros Passos

1. Restaurar e rodar o projeto ApiTarefaMVC:
   - dotnet restore
   - dotnet run --project ApiTarefaMVC
2. Opcional: rodar SQL Server em container:
   - docker pull mcr.microsoft.com/mssql/server:2025-latest
   - docker run -d --name mssql_agenda -p 1433:1433 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SuaSenhaForte123!' mcr.microsoft.com/mssql/server:2025-latest
3. Instalação das ferramentas necessárias para usar com o Entity Framework:
   - Microsoft.EntityFrameworkCore.SqlServer: Permite que o EF Core se comunique com o SQL Server (seu container Docker).
   - Microsoft.EntityFrameworkCore.Design: É necessário para rodar comandos como dotnet ef migrations no terminal.

---

## Segundo Passos

- Criação da classe Tarefa.cs dentro da pasta modelo
  - Atributos:
     1. Id:
        - Inteiro
     2. Titulo:
        - string
     3. Descricao:
        - string
     4. Data:
        - DateTime
     5. Status da Tarefa
        - Enum é uma classe base para definir enumeradores no csharp
        - Criando dentro da classe Models

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

- Próximo Passo (MVC e EF Core):
  - Criar pasta Context: precisamos de uma classe que herde o DbContext para que o EF Core saiba mapear sua entidade Tarefa para o banco de dados.
  - Configurando a Conexão: Definir o ConectionString no arquivo appsettings.Development.json caso o projeto não seja para produção e sim só desenvolvimento ou caso contrário mude o appsettings.json

```cs
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Threading.Tasks;
   using ApiTarefaMVC.Models;

   // Insira a clausura do Microsoft.EntityFrameworkCore para poder usar o DbContext
   using Microsoft.EntityFrameworkCore;

   namespace ApiTarefaMVC.Context
   {
      // A classe deve herdade de DbContext
      public class OrganizadorContext : DbContext
      {
         // Contrutor obrigatório para a injeção de dependência
         public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }
         //DbSet: Representa a tabela no banco de dados
         // A tabela será chamada 'Tarefas' (plural do nome da classe)
         public DbSet<Tarefa> Tarefas { get; set; }
      }
   }
```

- Configurar a Injeção de Dependência no Program.cs
   1. Precisamos dizer ao ASP.NET Core que use essa string de Conexão para configurar o DbContext
   2. No arquivo Program.cs

```cs
   using Microsoft.EntityFrameworkCore;
   using ApiTarefaMVC.Context; // 1. Importar o contexto

   var builder = WebApplication.CreateBuilder(args);

   // Adicionar serviço DbContext (INÍCIO DA CONFIGURAÇÃO)
   builder.Services.AddDbContext<OrganizadorContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
   );
   // Adicionar serviço DbContext (FIM DA CONFIGURAÇÃO)

   // Add services to the container.
   builder.Services.AddControllersWithViews();

   var app = builder.Build();

   // Configure the HTTP request pipeline.
   // ... (restante do código)

   app.Run();
```

## Terceiro Passo - Criando as migrations

### comando dotnet ef

```bash
   dotnet build # vode primeiro e veja se tem algum problema, caso não tenha, agora rode o sequinte comando:
   dotnet ef migrations add CriacaoInicialTarefas
   dotnet ef database update
```
