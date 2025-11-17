# Fundamentos Dotnet MVC

## Criando um projeto MVC

```bash
    dotnet new mvc
    dotnet watch run

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Erro na adicição dos pacotes SqlServer e Design

É muito incomum que o comando `dotnet add package` não adicione a referência ao arquivo **.csproj**. O comportamento padrão é que ele insira a tag `<PackageReference>` automaticamente.

O problema que você está enfrentando é quase sempre causado por uma das duas razões principais:

1. **Erro Silencioso:** A operação `dotnet add package` falhou por algum motivo (por exemplo, falta de acesso à internet/repositório NuGet) e o erro foi ignorado ou não percebido.
2. **Diretório Incorreto:** O comando `dotnet add package` foi executado em um diretório diferente de onde o arquivo **FundamentosWebApiMVC.csproj** está localizado.

### ✅ Solução Passo a Passo

Siga estas etapas para garantir que as referências sejam adicionadas corretamente:

#### 1\. Verifique o Diretório

O mais importante é garantir que você esteja no **diretório correto** ao executar o comando.

1. Abra seu terminal/prompt de comando.
2. Navegue até o diretório que contém o arquivo **FundamentosWebApiMVC.csproj**.
    * Exemplo: `cd C:\Caminho\Para\FundamentosWebApiMVC`
3. Execute o comando `dir` (Windows) ou `ls` (Linux/macOS) para **confirmar** que o arquivo `.csproj` está visível.

### 2\. Adicione os Pacotes Novamente

Estando no diretório correto, execute os comandos novamente. Desta vez, observe a saída do console para garantir que o processo seja concluído com sucesso:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

**Saída Esperada:** Você deve ver uma mensagem como:

> `Referências de pacote para o pacote 'Microsoft.EntityFrameworkCore.SqlServer' adicionadas ao projeto 'FundamentosWebApiMVC.csproj'.`

#### 3\. Verifique o Arquivo .csproj

Se os comandos forem bem-sucedidos, o seu arquivo **FundamentosWebApiMVC.csproj** (depois de recarregar no VS Code/Visual Studio) deve estar parecido com este:

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>disable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />
  </ItemGroup>

</Project>
```

**(Nota: A `Version` pode variar dependendo da versão mais recente do .NET 8 que você está usando, mas `8.0.0` é o padrão para o momento.)**

-----

#### 💡 Alternativa Manual (Se o Comando Falhar)

Se, mesmo no diretório correto, o comando `dotnet add package` continuar falhando ou não atualizar o arquivo, você pode **editar o arquivo FundamentosWebApiMVC.csproj manualmente** e adicionar as referências:

1. Abra o arquivo **FundamentosWebApiMVC.csproj** em um editor de texto (pode ser o próprio VS Code).
2. Insira o bloco `<ItemGroup>` com as referências, como mostrado abaixo, **imediatamente antes** da tag de fechamento `</Project>`:

<!-- end list -->

```xml
  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />
  </ItemGroup>
</Project>
```

Após salvar o arquivo, o Visual Studio Code (ou Visual Studio) irá detectar a mudança e solicitará que você **restaure os pacotes NuGet**. Se não o fizer automaticamente, execute:

```bash
dotnet restore
```

Com isso, os pacotes serão baixados, e você poderá seguir com a criação da sua classe `AgendaContext`.
