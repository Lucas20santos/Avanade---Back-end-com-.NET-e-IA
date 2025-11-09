# 📚 Web API: Organizador de Tarefas (.NET 8 + SQL Server)

Este projeto implementa uma Web API completa para gerenciamento de tarefas (CRUD) utilizando **ASP.NET Core** e **Entity Framework Core** com **SQL Server**.

## ⚙️ Configuração Principal do Projeto

| Item | Detalhe | Finalidade |
| :--- | :--- | :--- |
| **Framework** | .NET 8 | Versão LTS mais recente do .NET. |
| **Banco de Dados** | SQL Server | Usado para persistência dos dados. |
| **Contexto (DB)** | `OrganizadorContext` | Ponte entre a aplicação e o banco de dados (via EF Core). |
| **Modelo Principal** | `Tarefa` | Estrutura de dados para cada item de tarefa. |
| **Modelo Auxiliar** | `StatusTarefa` (`Enum`) | Define o estado da tarefa (Pendente, Em\_Andamento, Concluida). |

### Estrutura de Roteamento

- **Namespace do Controller:** `MinhasTarefas.Controllers` (Corrigido para o plural).
- **Rota Base:** `[Route("[controller]")]`
- **URL Base:** `http://localhost:<porta>/Tarefa`

---

## 💻 `TarefaController.cs` - Resumo dos Endpoints HTTP

O *Controller* `TarefaController` implementa todas as operações CRUD (Create, Read, Update, Delete) e métodos de busca avançada.

### Operações CRUD Básicas

| Método | Endpoint | Verbo HTTP | Ações e Retorno |
| :--- | :--- | :--- | :--- |
| `Create(Tarefa tarefa)` | `/Tarefa` | **POST** | Cria uma nova tarefa. Retorna **200 OK** com o objeto criado. |
| `Atualizar(int id, Tarefa tarefa)` | `/Tarefa/{id}` | **PUT** | Atualiza todos os campos de uma tarefa específica. Retorna **200 OK** com o objeto atualizado. |
| `Deletar(int id)` | `/Tarefa/{id}` | **DELETE** | Remove a tarefa do banco de dados. Retorna **204 No Content** (Sucesso sem corpo de resposta). |

### Operações de Leitura (GET)

| Método | Endpoint | Verbo HTTP | Parâmetros | Finalidade |
| :--- | :--- | :--- | :--- | :--- |
| `ObterTarefa()` | `/Tarefa/ObterTodos` | **GET** | *Nenhum* | Retorna a **lista completa** de todas as tarefas. |
| `ObterId(int id)` | `/Tarefa/{id}` | **GET** | `id` (no Path) | Busca e retorna uma tarefa pelo **ID** único. |
| `ObterTarefa(string titulo)` | `/Tarefa/ObterPorTitulo?titulo={valor}` | **GET** | `titulo` (Query) | Retorna tarefas que **contêm** o termo no Título (busca flexível/case-insensitive). |
| `GetPorTarefa(StatusTarefa status)` | `/Tarefa/ObterPorStatus/{status}` | **GET** | `status` (no Path) | Retorna tarefas que possuem o **Status** específico (`0`, `1`, `2` ou o nome do Enum). |
| `GetPorPeriodo(...)` | `/Tarefa/ObterPorPeriodo?dataInicio={d1}&dataFim={d2}` | **GET** | `dataInicio`, `dataFim` (Query) | Retorna tarefas agendadas entre o **período** de data e hora especificado. |
| `GetPorData(...)` | `/Tarefa/ObterPorData?data={d}` | **GET** | `data` (Query) | Retorna tarefas agendadas exatamente na **data** especificada (com ajuste de horário). |

---

## 🔗 Configuração do `OrganizadorContext`

Para a conexão com o SQL Server, o projeto utiliza a injeção de dependência no `Program.cs` e a *Connection String* definida em `appsettings.Development.json`:

### `Program.cs`

A injeção do `OrganizadorContext` é essencial:

```csharp
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);
```

### `appsettings.Development.json`

A string de conexão deve ser configurada aqui para o SQL Server. **Atenção:** Mantenha a senha segura e garanta que o serviço do SQL Server esteja acessível.

```json
"ConnectionStrings": {
    "ConexaoPadrao": "Server=localhost,1433; Initial Catalog=Tarefa; User Id=sa; Password=SuaSenhaForte123!; TrustServerCertificate=True; MultipleActiveResultSets=True"
}
```

### 🔑 Migrations

O banco de dados foi criado e mapeado usando o **Entity Framework Core Migrations**:

```bash
# 1. Cria o snapshot do modelo
dotnet ef migrations add InitialCreate

# 2. Aplica as mudanças no banco de dados (SQL Server)
dotnet ef database update
```

---

Para mais informações visite o [Saiba Mais](./SaibaMais.md). No **Saiba Mais** você encontrar informações completa sobre o projeto e todo passo a passo da construção do mesmo.
