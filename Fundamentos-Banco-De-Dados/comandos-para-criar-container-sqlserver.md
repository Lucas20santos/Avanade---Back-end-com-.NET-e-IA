# Passo a passo da criação de um container no docker do sqlserver

## Comandos

### Comando de instalação

```bash
    docker pull mcr.microsoft.com/mssql/server:2025-latest
```

### Resposta terminal 1

```bash
    2025-latest: Pulling from mssql/server
    2f1e22101123: Pull complete 
    df1d44f75adf: Pull complete 
    faec9481280b: Pull complete 
    Digest: sha256:2c80e548ef65fb65a8ca23c3a74ed60e0964ea709f46d07c97ccaf7c437e2cc6
    Status: Downloaded newer image for mcr.microsoft.com/mssql/server:2025-latest
    mcr.microsoft.com/mssql/server:2025-latest
```

## Verificando instalação

### docker images

```bash
    docker images
```

### Resposta terminal 2

```bash
    docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<password>" \
   -p 1433:1433 --name sql1 --hostname sql1 \
   -d \
   mcr.microsoft.com/mssql/server:2025-latest
```

### Explicação do comando acima retirada da documentação

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

## Estrutura do docker compose

### [Dominando o Docker Compose: Guia completo para gerenciamento de multi-contêineres](https://blog.4linux.com.br/docker-compose-explicado/)

- Usado para execultar vários container de uma só vez e ainda incluir os parametros necessários, criação de rede e volumes, se necessario;
- Usado para facilitar o provisionamento e gerenciamentos de multi-contâineres principalmente em ambiente de desenvolvimento, testes automaticos e cenário de execultação de unico host;
- O Docker compose é instalado separadamento do docker engine.

### Comandos do docker compose

- docker-compose up: cria e inicia os contêineres;
- docker-compose build: realiza apenas a etapa de build das imagens que serão utilizadas;
- docker-compose logs: visualiza os logs dos contêineres;
- docker-compose restart: reinicia os contêineres;
- docker-compose ps: lista os contêineres;
- docker-compose scale: permite aumentar o número de réplicas de um contêiner;
- docker-compose start: inicia os contêineres;
- docker-compose stop: paralisa os contêineres;
- docker-compose down: paralisa e remove todos os contêineres e seus componentes como rede, imagem e volume.

### Script para execução do docker compose de nome docker-compose.yml

```yml
services:
  # ----------------------------------------------------
  # 1. Serviço do Banco de Dados (db)
  # ----------------------------------------------------
  db:
    image: mongo
    container_name: db
    restart: always
    environment:
      - MONGO_INITDB_ROOT_USERNAME=dio
      - MONGO_INITDB_ROOT_PASSWORD=dio
    ports: 
      - "27017:27017"
    volumes:
      # Usar Volumes Nomeados é a melhor prática para persistência de dados
      - mongo_data:/data/db 

# ----------------------------------------------------
# 2. Volumes Nomeados (para persistência de dados)
# ----------------------------------------------------
volumes:
  mongo_data:
    # Opcional: define um driver de volume
```
