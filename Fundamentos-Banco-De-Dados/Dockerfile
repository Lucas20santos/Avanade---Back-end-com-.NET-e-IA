# Estágio 1: Build (Compilação)
# Usamos uma imagem completa para compilar o código
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["NomeDoSeuProjeto/NomeDoSeuProjeto.csproj", "NomeDoSeuProjeto/"]
RUN dotnet restore "NomeDoSeuProjeto/NomeDoSeuProjeto.csproj"

# Copia todo o código-fonte
COPY . .
WORKDIR "/src/NomeDoSeuProjeto"
RUN dotnet build "NomeDoSeuProjeto.csproj" -c Release -o /app/build

# Estágio 2: Publish (Publicação)
# Publica os arquivos necessários para execução
FROM build AS publish
RUN dotnet publish "NomeDoSeuProjeto.csproj" -c Release -o /app/publish

# Estágio 3: Final (Execução)
# Usamos uma imagem base leve (runtime) para o contêiner final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Comando de inicialização:
# Assumimos que o endpoint de escuta padrão é 8080 (ASP.NET Core)
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "NomeDoSeuProjeto.dll"]