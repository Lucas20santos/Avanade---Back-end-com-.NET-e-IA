# Funadmentos API

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

```cs
    // criação do projeto webapi
    dotnet new webapi
    // instalando o entity framework e sua depencias
    dotnet tool install --global dotnet-ef
    // Os pacotes abaixos precisam ser instalados em cada projeto que é criado o de cima não é uma vez por toda.
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    // Antes de rodar esse comando leia toda a explicação abaixo
    dotnet-ef migrations add CriacaoTabelaContato
    // Agora vamos aplicar nossa Migrations com o seguinte comando
    dotnet-ef database update
    // Parando o container do sql server no docker
    docker stop mssql_agenda
    // Quando precisar rodar novamente eu rodo
    docker start mssql_agenda
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

### Pergunta Sobre essa parte aqui: Integrated Security=True eu estou usando uma maquina linux, vai ter problema ?

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
