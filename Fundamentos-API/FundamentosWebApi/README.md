# Fundamentos API

<!-- Sumário adicionado abaixo -->
## Sumário

- [Fundamentos API](#fundamentos-api)
- [Comandos básicos para criação de projeto console](#comandos-b%C3%A1sicos-para-cria%C3%A7%C3%A3o-de-projeto-console)
- [Criando um projeto Web API e instalando as ferramentas](#criando-uma-projeto-webapi-e-instalando-as-ferramentas)
- [String de conexão com o banco de dados sql server](#string-de-conex%C3%A3o-com-o-banco-de-dados-sql-server)
- [Estrutura do Código](#estrutura-do-c%C3%B3digo)
  - [📁 Context](./Context/)
  - [🗂️ Controllers](./Controllers/)
  - [🧾 Migrations](./Migrations/)
  - [🧩 Models](./Models/)
- [Árvore do Projeto](#%C3%A1rvore-do-projeto)

## Árvore do Projeto

Exemplo da estrutura esperada do repositório (ajuste conforme a sua pasta real):

```text
/FundamentosWebApi
├─ .vscode/
├─ Controllers/
│  └─ ContatoController.cs
├─ Context/
│  └─ ApplicationDbContext.cs
├─ Migrations/
│  ├─ 20250xxxxx_CriacaoTabelaContato.cs
│  └─ ApplicationDbContextModelSnapshot.cs
├─ Models/
│  └─ Contato.cs
├─ appsettings.json
├─ Program.cs
├─ FundamentosWebApi.csproj
└─ README.md
```

## Comandos básicos para criação de projeto console

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

## criando uma projeto webapi e instalando as ferramentas

### No docker

#### Baixando a imagem do sqlServer

```bash
    docker pull mcr.microsoft.com/mssql/server:2025-latest
```

#### Verificicando as imagens

```sh
  docker images
```

#### Criação de um usuario e um senha

```bash
  docker run -d \
    --name mssql_agenda \
    -p 1433:1433 \
    -e 'ACCEPT_EULA=Y' \
    -e 'SA_PASSWORD=SuaSenhaForte123!' \
    mcr.microsoft.com/mssql/server:2025-latest

```

#### Iniciando ou parando um container

```sh
  docker start mssql_agenda

  docker stop mssql_agenda
```

#### Explicação do comando acima retirada da documentação

|Parâmetro|Descrição|
|:------:|----------|
|-e "ACCEPT_EULA=Y"|Defina a variável ACCEPT_EULA com qualquer valor para confirmar sua aceitação do Contrato de Licença do Usuário Final. Configuração exigida para a imagem do SQL Server.|
|-e "MSSQL_SA_PASSWORD=\<password>"|Especifique sua própria senha forte que tenha pelo menos oito caracteres e atenda à Política de senha. Configuração exigida para a imagem do SQL Server.|
|-e "MSSQL_COLLATION=<SQL_Server_collation>"|Especifique uma ordenação personalizada do SQL Server, em vez do padrão SQL_Latin1_General_CP1_CI_AS.|
|-p 1433:1433| Mapeie uma porta TCP no ambiente do host (primeiro valor) para uma porta TCP no contêiner (segundo valor). Neste exemplo, o SQL Server está escutando na TCP 1433 no contêiner e essa porta de contêiner é exposta para a porta TCP 1433 no host.|
|--name sql1| Especifique um nome personalizado para o contêiner em vez de um nome gerado aleatoriamente. Se você executar mais de um contêiner, não será possível reutilizar esse mesmo nome.|
|--hostname sql1 |Usado para definir explicitamente o nome do host do contêiner. Se você não especificar o nome do host, o padrão será a ID do contêiner, que é um GUID do sistema gerado aleatoriamente.|
|-d| Execute o contêiner em segundo plano (daemon).|
|mcr.microsoft.com/mssql/server:2025-latest| A imagem de contêiner do SQL Server Linux.|

### No dotnet

#### Criação do projeto webapi

```cs
    dotnet new webapi
```

#### instalando o entity framework e sua depencias

```sh
    dotnet tool install --global dotnet-ef
```

##### Instalação de pacotes para desenvolver o projeto

```sh
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

#### Antes de rodar esse comando leia toda a explicação abaixo

```sh
    dotnet-ef migrations add CriacaoTabelaContato
    dotnet-ef database update
```

## String de conexão com o banco de dados sql server

A string Server=localhost\\sqlexpress; Initial Catalog=Agenda; Integrated Security=True especifica os seguintes parâmetros:

- Server=localhost\\sqlexpress: Indica que o servidor de banco de dados está na máquina local (localhost) e usa a instância nomeada sqlexpress, que é o nome padrão para instalações do SQL Server Express.
- Initial Catalog=Agenda: Define que o banco de dados padrão a ser usado após a conexão é o banco de dados chamado Agenda.
- Integrated Security=True: Habilita a Autenticação do Windows (também pode ser escrito como Trusted_Connection=True). Isso significa que a aplicação usará a identidade do usuário do Windows que está executando o processo para se autenticar no SQL Server, sem a necessidade de um login e senha explícitos no código.

### Pontos a verificar

1. Nome da Instância: Confirme se a sua instância do SQL Server Express tem exatamente o nome SQLEXPRESS. Às vezes, as pessoas instalam com nomes diferentes.
1. Nome do Banco de Dados: Certifique-se de que um banco de dados chamado Agenda já existe na sua instância do SQL Server.
1. Configuração no .NET: No seu código .NET, você deve carregar essa string de conexão a partir do appsettings.json (ou web.config no Framework) e passá-la para o seu DbContext (se estiver usando Entity Framework) ou SqlConnection.

### Exemplo de como usar no .NET Core (startup.cs ou program.cs)

```csharp
    // Exemplo em Program.cs para .NET 6+
    var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");
    
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
```

### Pergunta: Sobre essa parte aqui: Integrated Security=True eu estou usando uma maquina linux, vai ter problema ?

Sim, você terá um problema significativo.

O parâmetro Integrated Security=True (ou Trusted_Connection=True) é projetado para usar a Autenticação do Windows (Windows Authentication). Ele instrui o driver a usar as credenciais do usuário do Windows que está executando o aplicativo para se autenticar no SQL Server.

#### O problema no Linux

O Linux não possui o sistema nativo de autenticação do Windows (como NTLM ou Kerberos) configurado por padrão da mesma forma que o Windows.

Quando seu aplicativo .NET rodando em Linux tenta usar Integrated Security=True, ele não consegue encontrar as credenciais de domínio/Windows necessárias e a conexão falhará.

#### Soluções alternativas

Você tem duas opções principais ao rodar em um ambiente Linux:

1. (Recomendado) Usar Autenticação do SQL Server (SQL Server Authentication)

Esta é a abordagem mais simples e comum para cenários multiplataforma (Windows e Linux). Você cria um login e senha diretamente no SQL Server e usa essas credenciais na sua string de conexão.

#### Como mudar sua string de conexão

Altere sua string de conexão para incluir User Id e Password, e remova ou defina Integrated Security como False:

```json
"ConnectionStrings": {
  "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=Agenda; User Id=SEU_USUARIO_SQL; Password=SUA_SENHA_FORTE"
}
```

Use o código com cuidado.

Lembre-se de substituir SEU_USUARIO_SQL e SUA_SENHA_FORTE pelas credenciais que você criou no SQL Server.

1. Configurar Autenticação Integrada via Kerberos (Mais Complexo)

É possível fazer a Autenticação do Windows funcionar a partir do Linux, mas isso exige uma configuração de infraestrutura complexa:

- Sua máquina Linux precisa estar ingressada em um domínio do Active Directory (AD).
- Você precisa configurar corretamente o Kerberos na máquina Linux.
- Você precisa garantir que o driver .NET (SqlClient) e o SQL Server estejam configurados para usar Kerberos para essa conexão.

Para a maioria dos projetos de desenvolvimento ou aplicações simples, a Autenticação do SQL Server (Opção 1) é a solução mais prática e rápida.

### Pergunta Mas para um container docker segue a mesma alteração acima

Sim, a mesma lógica se aplica a um container Docker, e a alteração para usar a Autenticação do SQL Server é altamente recomendada nesse cenário.

#### Por que a Autenticação do SQL Server é o padrão em Containers\?

Containers Docker (que geralmente rodam Linux) são, por natureza, isolados do sistema operacional host.

1. Isolamento do Host: O container Linux não tem acesso nativo às credenciais do usuário Windows da máquina hospedeira.
1. Portabilidade: Você quer que seu container inicie e funcione independentemente de onde ele está rodando (sua máquina local, um servidor de CI/CD, a nuvem). Usar credenciais de usuário e senha na string de conexão torna a aplicação portátil.

#### A String de Conexão no Docker

Sua string de conexão no appsettings.json deve ser alterada para usar User Id e Password, assim como na sugestão anterior:

```json
"ConnectionStrings": {
  // Use esta string de conexão para compatibilidade multiplataforma e Docker
  "ConexaoPadrao": "Server=SEU_SERVIDOR_IP_OU_NOME; Initial Catalog=Agenda; User Id=SEU_USUARIO_SQL; Password=SUA_SENHA_FORTE"
}
```

Use o código com cuidado.

Detalhe Importante: O Endereço do Servidor (Server=...)
Além da mudança de autenticação, você provavelmente precisará mudar o valor de Server:
localhost\\sqlexpress não funcionará dentro do container para se referir ao seu host Windows. localhost dentro do container refere-se ao próprio container.
Você precisará usar o endereço IP real da máquina host Windows na rede Docker, ou o nome do serviço se o banco de dados estiver em outro container Docker Compose.
Exemplo de string de conexão para Docker:
Se o seu SQL Server estiver em um container Docker separado chamado dbserver:

```json
"ConnectionStrings": {
  "ConexaoPadrao": "Server=dbserver; Initial Catalog=Agenda; User Id=sa; Password=SuaSenhaForte123"
}
```

Use o código com cuidado.

Se o seu SQL Server estiver rodando diretamente na sua máquina Windows host, e você estiver configurando a rede Docker corretamente para acessá-la:

```json
"ConnectionStrings": {
  // Você precisará descobrir o IP interno da sua máquina host na rede Docker
  "ConexaoPadrao": "Server=172.17.0.1; Initial Catalog=Agenda; User Id=sa; Password=SuaSenhaForte123"
}
```

Use o código com cuidado.

Em resumo: A Autenticação do Windows (Integrated Security=True) é uma tecnologia específica do Windows e não funciona de forma transparente em ambientes Linux ou Containers Docker. Use a Autenticação do SQL Server e configure a conectividade de rede corretamente entre o container e o servidor de banco de dados.

## Estrutura do Código

A seguir uma descrição das pastas principais deste projeto e do papel do código dentro de cada uma delas. Ela explica conceitualmente o que cada pasta serve e o que o código nela contido faz para o funcionamento da aplicação.

### 📁 [Context](./Context/)

- O que é: contém a implementação do DbContext (ex: ApplicationDbContext) usado pelo Entity Framework Core.
- Função conceitual: representa a sessão com o banco de dados; mapeia entidades (Models) para tabelas e fornece DbSet\<T> para operações CRUD.
- Código típico e o que faz:
  - propriedade DbSet\<Contato> Contatos — expõe a coleção de contatos para consultas e alterações.
  - construtor que recebe DbContextOptions e chama base(options) — permite a configuração via DI (AddDbContext).
  - método OnModelCreating(ModelBuilder modelBuilder) — configura regras de mapeamento (nomes de tabela, tipos, índices, relações, constraints).
  - registro no Program.cs/Startup: builder.Services.AddDbContext\<ApplicationDbContext>(options => options.UseSqlServer(...)) — integra o contexto ao pipeline da aplicação.
- Resultado para o programa: fornece a API de acesso ao banco, traduz LINQ em SQL e controla o rastreamento de entidades e persistência (SaveChanges / SaveChangesAsync).

### 🗂️ [Controllers](./Controllers/)

- O que é: contém controladores Web API (ex: ContatoController) que expõem endpoints HTTP (GET, POST, PUT, DELETE).
- Função conceitual: recebem requisições HTTP, validam dados, coordenam operações de domínio (aqui, via DbContext) e retornam respostas HTTP (200, 201, 404, 400...).
- Código típico e o que faz:
  - anotações [ApiController] e [Route("api/[controller]")] — ativam comportamento de API e definem rota base.
  - ações:
    - GET /api/contatos — busca todos os registros; normalmente retorna Ok(lista).
    - GET /api/contatos/{id} — busca por id; se não encontrado, retorna NotFound.
    - POST /api/contatos — cria novo registro; valida ModelState, adiciona ao DbContext e chama SaveChanges, retorna CreatedAtAction.
    - PUT /api/contatos/{id} — atualiza registro; verifica existência, aplica alterações e SaveChanges.
    - DELETE /api/contatos/{id} — remove registro e SaveChanges.
  - injeção do ApplicationDbContext via construtor — o controller usa o contexto para acessar o banco.
- Resultado para o programa: transforma chamadas HTTP em operações no banco e define contrato REST da API.

### 🧾 [Migrations](./Migrations/)

- O que é: pasta gerada pelo Entity Framework Core que contém classes de migração e o arquivo de snapshot do modelo.
- Função conceitual: versiona alterações do esquema do banco; cada migração tem métodos Up (aplica mudanças) e Down (reverte).
- Código típico e o que faz:
  - classe de migração (ex: 20250xxxxx_CriacaoTabelaContato) com Up criando tabela Contatos (colunas, tipos, constraints) e Down removendo-a.
  - ModelSnapshot — representa o estado atual do modelo para que o EF saiba quais mudanças criar nas próximas migrações.
- Resultado para o programa: possibilita criar/atualizar o banco de dados a partir do modelo de código (dotnet-ef migrations add / dotnet-ef database update) garantindo consistência entre modelo e esquema.

### 🧩 [Models](./Models/)

- O que é: contém as classes que representam as entidades do domínio (ex: Contato.cs).
- Função conceitual: definem a forma dos dados, validações e regras simples de negócio no nível da entidade.
- Código típico e o que faz:
  - propriedades (ex: int Id, string Nome, string Email, string Telefone).
  - Data Annotations ([Key], [Required], [MaxLength], [EmailAddress]) — definem validação e influenciam migrações (tamanho de colunas, nulabilidade).
  - possivelmente métodos auxiliares ou validações internas (ex: validar formato, máscaras).
- Resultado para o programa: modelos definem contrato de dados usados pelo DbContext, pelas migrações e pelos controllers; garantem validação automática do modelo recebido na API.

Resumo de integração

- Fluxo típico: Controller recebe a requisição -> valida o Model (ModelState) -> usa ApplicationDbContext (Context) para consultar/alterar Models -> EF gera SQL baseado nas Models/Migrations -> banco persiste os dados.
- Ferramentas importantes: dotnet-ef para gerar e aplicar Migrations; DI do .NET para injetar o DbContext; atributos de validação para proteger a entrada de dados.

Boas práticas rápidas

- Manter Models simples e focadas em dados; regras de negócio mais complexas podem ir para uma camada de serviço.
- Usar DTOs para entrada/saída quando precisar separar entidade de contrato HTTP.
- Versionar migrações e não editar migrações já aplicadas em produção; gere novas migrações para alterações.
- Tratar exceções de acesso a dados e retornar códigos HTTP adequados
