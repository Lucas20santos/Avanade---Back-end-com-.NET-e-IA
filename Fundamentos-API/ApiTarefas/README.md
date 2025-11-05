# Api de tarefa

## Sumário

- Visão rápida
- Como executar
- Estrutura do projeto (árvore)
- Arquivos auxiliares fora do projeto ApiTarefaMVC

## Visão rápida

Projeto exemplo de API MVC para gerenciar tarefas (CRUD) usado na trilha .NET. Contém endpoints para criar, ler, atualizar e deletar tarefas e exemplos para rodar com Docker / SQL Server.

## Como executar (rápido)

1. Restaurar e rodar o projeto ApiTarefaMVC:
   - dotnet restore
   - dotnet run --project ApiTarefaMVC
2. Opcional: rodar SQL Server em container:
   - docker pull mcr.microsoft.com/mssql/server:2025-latest
   - docker run -d --name mssql_agenda -p 1433:1433 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SuaSenhaForte123!' mcr.microsoft.com/mssql/server:2025-latest

---

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
