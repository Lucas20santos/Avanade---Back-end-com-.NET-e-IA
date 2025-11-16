# 🎬 FilmesDB — Banco de Dados de Filmes

Um projeto completo de banco de dados para registrar **filmes, gêneros, atores e participação no elenco**, utilizando **SQL Server em Docker** e visualização via **DBeaver**.

<p align="center">
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white" />
  <img src="https://img.shields.io/badge/DBeaver-372923?logo=dbeaver&logoColor=white" />
  <img src="https://img.shields.io/badge/Status-Ativo-brightgreen" />
</p>

---

## 📚 **Sumário**

* [Descrição](#-descrição)
* [Arquitetura do Banco](#-arquitetura-do-banco)
* [Tecnologias Usadas](#-tecnologias-usadas)
* [Como Rodar o SQL Server no Docker](#-como-rodar-o-sql-server-no-docker)
* [Importando no DBeaver](#-importando-no-dbeaver)
* [Script de Criação das Tabelas](#-script-de-criação-das-tabelas)
* [Inserts de Exemplo](#-inserts-de-exemplo)
* [Consultas Úteis](#-consultas-úteis)
* [Contribuição](#-contribuição)
* [Licença](#-licença)

---

## 📝 **Descrição**

O **FilmesDB** é um banco de dados projetado para armazenar informações relacionadas a filmes, incluindo:

* Dados dos filmes
* Gêneros
* Atores e elenco
* Relacionamentos entre tabelas com cardinalidade N:N

Ideal para estudos de SQL, normalização e consultas com JOINs.

---

## 🏛️ **Arquitetura do Banco**

```
📁 filmes-db
│
├── Filmes
│     └── Id, Nome, Ano, Duracao, Diretor
│
├── Generos
│     └── Id, Genero
│
├── Atores
│     └── Id, PrimeiroNome, UltimoNome, DataNascimento
│
├── FilmesGenero  (N:N)
│     └── IdFilme, IdGenero
│
└── ElencoFilme   (N:N)
      └── IdFilme, IdAtor, Papel
```

---

## 🛠️ **Tecnologias Usadas**

* **SQL Server 2022** (rodando em Docker)
* **Docker Desktop / Docker Engine**
* **DBeaver Community Edition**
* **SQL (T-SQL)**

---

## 🐳 **Como Rodar o SQL Server no Docker**

### 1️⃣ Baixe a imagem

```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
```

### 2️⃣ Suba o container

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" \
   -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest
```

✔ Porta exposta: `1433`
✔ Usuário padrão: `sa`

---

## 🦫 **Importando no DBeaver**

1. Abra o DBeaver
2. Clique em **New Connection**
3. Escolha **SQL Server**
4. Configure:

   * Host: `localhost`
   * Porta: `1433`
   * Usuário: `sa`
   * Senha: *sua senha*
5. Teste a conexão e finalize

---

## 🧱 **Script de Criação das Tabelas**

```sql
CREATE TABLE Filmes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100),
    Ano INT,
    Duracao INT,
    Diretor VARCHAR(100)
);

CREATE TABLE Generos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Genero VARCHAR(100)
);

CREATE TABLE Atores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PrimeiroNome VARCHAR(50),
    UltimoNome VARCHAR(50),
    DataNascimento DATE
);

CREATE TABLE FilmesGenero (
    IdFilme INT FOREIGN KEY REFERENCES Filmes(Id),
    IdGenero INT FOREIGN KEY REFERENCES Generos(Id)
);

CREATE TABLE ElencoFilme (
    IdFilme INT FOREIGN KEY REFERENCES Filmes(Id),
    IdAtor INT FOREIGN KEY REFERENCES Atores(Id),
    Papel VARCHAR(100)
);
```

---

## 🧩 **Inserts de Exemplo**

```sql
INSERT INTO Generos (Genero) VALUES
('Ação'), ('Drama'), ('Comédia'), ('Mistério');

INSERT INTO Filmes (Nome, Ano, Duracao, Diretor) VALUES
('O Enigma', 2012, 140, 'John Kent'),
('Noite Sombria', 2017, 118, 'Marco Alves');

INSERT INTO Atores (PrimeiroNome, UltimoNome, DataNascimento) VALUES
('Ana', 'Souza', '1990-04-10'),
('Carlos', 'Lima', '1982-11-22');

INSERT INTO FilmesGenero VALUES (1,4), (2,1);
INSERT INTO ElencoFilme VALUES (1,1,'Detetive'),(1,2,'Vilão');
```

---

## 🔍 **Consultas Úteis**

### 🎥 Filmes e seus gêneros

```sql
SELECT f.Nome, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON g.Id = fg.IdGenero;
```

### 🎭 Filmes e atores do elenco

```sql
SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel
FROM Filmes f
JOIN ElencoFilme ef ON f.Id = ef.IdFilme
JOIN Atores a ON a.Id = ef.IdAtor;
```

### 🕵️ Filmes de gênero “Mistério”

```sql
SELECT f.Nome, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON g.Id = fg.IdGenero
WHERE g.Genero = 'Mistério';
```

---

## 🤝 **Contribuição**

Contribuições são bem-vindas!
Sinta-se livre para abrir **Issues** ou **Pull Requests**.

---

## 📄 **Licença**

Este projeto está sob a licença MIT. Pode usar, modificar e distribuir.

---

💬 Caso deseje, posso adicionar:

* GIF do banco funcionando
* Mais badges
* Imagens do DBeaver
* Scripts de migração

Só pedir! 🚀

---

## 🗺️ **Roadmap do Projeto**

* [x] Modelagem do banco de dados
* [x] Criação das tabelas
* [x] Criação dos INSERTs iniciais
* [x] Configuração do SQL Server no Docker
* [x] Conexão com DBeaver
* [ ] Criar stored procedures úteis
* [ ] Criar triggers de auditoria
* [ ] Criar views para relatórios
* [ ] Adicionar mais datasets (filmes, atores, gêneros)
* [ ] Criar versionamento com scripts de migração

---

## 📸 **Screenshots (Placeholders)**

<p align="center">
  <img src="https://via.placeholder.com/600x300?text=DBeaver+-+Vis%C3%A3o+Geral+do+Banco" />
  <br>
  <em>DBeaver visualizando as tabelas do FilmesDB</em>
</p>

<p align="center">
  <img src="https://via.placeholder.com/600x300?text=Consulta+SQL+Executada+com+Sucesso" />
  <br>
  <em>Consulta SQL retornando filmes e atores</em>
</p>

---

## 🎞️ **Demonstração do Projeto (GIF Placeholder)**

<p align="center">
  <img src="https://via.placeholder.com/500x280?text=GIF+da+Execu%C3%A7%C3%A3o+do+Projeto" />
  <br>
  <em>GIF mostrando a execução de consultas no DBeaver</em>
</p>

---

## 🎨 **Logo do Projeto (Minimalista)**

<p align="center">
  <img src="https://via.placeholder.com/150?text=FilmesDB+Logo" />
  <br>
  <em>Logo simples para o projeto</em>
</p>

---

## 📘 **Aprendizados com o Projeto**

Durante o desenvolvimento do FilmesDB, foram reforçados conhecimentos essenciais como:

* Criação e normalização de banco de dados
* Relacionamentos N:N utilizando tabelas intermediárias
* JOINs simples e avançados
* Configuração de containers Docker com SQL Server
* Importação e visualização de dados no DBeaver
* Execução de consultas complexas e análise de resultados
* Organização de um projeto técnico para portfólio

Este projeto demonstra domínio prático de SQL, modelagem e infraestrutura leve com Docker — ideal para apresentar em entrevistas e no GitHub.
