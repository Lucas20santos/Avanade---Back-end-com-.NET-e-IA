# Resolucao do Desafio do Projeto

## Criação do Banco de Dados e Tabelas

### 1. Crie o banco de dados

```sql
### cria o banco (rode apenas se quiser um DB novo)

IF DB_ID('FilmesDB') IS NOT NULL
    DROP DATABASE FilmesDB;

CREATE DATABASE FilmesDB;

USE FilmesDB;
```

### 2. Criar tabela Generos

```sql
CREATE TABLE Generos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Genero VARCHAR(20) NULL
);
```

### 3. Criar tabela Atores

```sql
CREATE TABLE Atores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PrimeiroNome VARCHAR(20) NULL,
    UltimoNome  VARCHAR(20) NULL,
    Genero      VARCHAR(1)  NULL  ### se for M/F ou usar FK para Generos se preferir

);
```

### 4. Criar tabela Filmes

```sql
CREATE TABLE Filmes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(50) NULL,
    Ano  INT NULL,
    Duracao INT NULL
);

```

### 5. Criar tabela de ligação FilmesGenero (muitos-para-muitos Filmes <-> Generos)

```sql
CREATE TABLE FilmesGenero (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdGenero INT NULL,
    IdFilme  INT NULL,
    CONSTRAINT FK_FilmesGenero_Generos FOREIGN KEY (IdGenero) REFERENCES Generos(Id),
    CONSTRAINT FK_FilmesGenero_Filmes  FOREIGN KEY (IdFilme)  REFERENCES Filmes(Id)
);
```

### 6. Criar tabela ElencoFilme (atores em filmes — outro many-to-many com role)

```sql
CREATE TABLE ElencoFilme (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdAtor INT NOT NULL,
    IdFilme INT NULL,
    Papel VARCHAR(30) NULL,
    CONSTRAINT FK_ElencoFilme_Atores FOREIGN KEY (IdAtor) REFERENCES Atores(Id),
    CONSTRAINT FK_ElencoFilme_Filmes  FOREIGN KEY (IdFilme) REFERENCES Filmes(Id)
);
```

## Inserindo dados

### 🎭 **Atores**

```sql
INSERT INTO Atores (PrimeiroNome, UltimoNome, Genero) VALUES
('James', 'Stewart', 'M'),
('Deborah', 'Kerr', 'F'),
('Peter', 'OToole', 'M'),
('Robert', 'DeNiro', 'M'),
('Harrison', 'Ford', 'M'),
('Stephen', 'Baldwin', 'M'),
('Jack', 'Nicholson', 'M'),
('Mark', 'Wahlberg', 'M'),
('Woody', 'Allen', 'M'),
('Claire', 'Danes', 'F'),
('Tim', 'Robbins', 'M'),
('Kevin', 'Spacey', 'M'),
('Kate', 'Winslet', 'F'),
('Robin', 'Williams', 'M'),
('Jon', 'Voight', 'M'),
('Ewan', 'McGregor', 'M'),
('Christian', 'Bale', 'M'),
('Maggie', 'Gyllenhaal', 'F'),
('Dev', 'Patel', 'M'),
('Sigourney', 'Weaver', 'F'),
('David', 'Aston', 'M'),
('Ali', 'Astin', 'F');
```

---

### 🎬 **Filmes**

```sql
INSERT INTO Filmes (Nome, Ano, Duracao) VALUES
('Um Corpo que Cai', 1958, 128),
('Os Inocentes', 1961, 100),
('Lawrence da Arábia', 1962, 216),
('O Franco Atirador', 1978, 183),
('Amadeus', 1984, 160),
('Blade Runner', 1982, 117),
('De Olhos Bem Fechados', 1999, 159),
('Os Suspeitos', 1995, 106),
('Chinatown', 1974, 130),
('Boogie Nights - Prazer Sem Limites', 1997, 155),
('Noivo Neurótico, Noiva Nervosa', 1977, 93),
('Princesa Mononoke', 1997, 134),
('Um Sonho de Liberdade', 1994, 142),
('Beleza Americana', 1999, 122),
('Titanic', 1997, 194),
('Gênio Indomável', 1997, 126),
('Amargo pesadelo', 1972, 109),
('Trainspotting - Sem Limites', 1996, 94),
('O Grande Truque', 2006, 130),
('Donnie Darko', 2001, 113),
('Quem Quer Ser um Milionário?', 2008, 120),
('Aliens, O Resgate', 1986, 137),
('Uma Vida sem Limites', 2004, 118),
('Avatar', 2009, 162),
('Coração Valente', 1995, 178),
('Os Sete Samurais', 1954, 207),
('A Viagem de Chihiro', 2001, 125),
('De Volta para o Futuro', 1985, 116);
```

---

### 🎭 **ElencoFilme**

```sql
INSERT INTO ElencoFilme (IdAtor, IdFilme, Papel) VALUES
(1, 1, 'John Scottie Ferguson'),
(2, 2, 'Miss Giddens'),
(3, 3, 'T.E. Lawrence'),
(4, 4, 'Michael'),
(5, 6, 'Rick Deckard'),
(6, 8, 'McManus'),
(8, 9, 'J.J. Gittes'),
(9, 10, 'Eddie Adams'),
(10, 11, 'Alvy Singer'),
(11, 12, 'San'),
(12, 13, 'Andy Dufresne'),
(13, 14, 'Lester Burnham'),
(14, 15, 'Rose DeWitt Bukater'),
(15, 16, 'Sean Maguire'),
(16, 17, 'Ed'),
(17, 18, 'Renton'),
(19, 20, 'Elizabeth Darko'),
(20, 21, 'Older Jamal'),
(21, 22, 'Ripley'),
(13, 23, 'Bobby Darin'),
(18, 19, 'Alfred Borden');
```

---

### 🏷 **Generos**

```sql
INSERT INTO Generos (Genero) VALUES
('Ação'),
('Aventura'),
('Animação'),
('Biografia'),
('Comédia'),
('Crime'),
('Drama'),
('Horror'),
('Musical'),
('Mistério'),
('Romance'),
('Suspense'),
('Guerra');
```

---

### 🎞 **FilmesGenero**

Aqui também só colocamos **IdGenero e IdFilme**, sem o ID.

```sql
INSERT INTO FilmesGenero (IdGenero, IdFilme) VALUES
(1, 22),
(2, 17),
(2, 3),
(3, 12),
(5, 11),
(6, 8),
(6, 13),
(7, 26),
(7, 28),
(7, 18),
(7, 21),
(8, 2),
(9, 23),
(10, 7),
(10, 27),
(10, 1),
(11, 14),
(12, 6),
(13, 4);
```

## Consultas dados dados e repostas ao Desafio

### Usando a tabela FilmesDb

```sql
Use FilmesDb;
```

### Buscando por nome e ano

```sql
SELECT Nome, Ano FROM Filmes;
```

### Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano

```sql
SELECT Nome, Ano, Duracao FROM Filmes
ORDER BY ANO;
```

### Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração

```sql
SELECT Nome, Ano, Duracao FROM Filmes
WHERE Nome = 'De Volta Para o Futuro'
```

### Buscar os filmes lançados em 1997

```sql
SELECT Nome, Ano, Duracao FROM Filmes
WHERE Ano = 1997
```

### Buscar os filmes lançados APÓS o ano 2000

```sql
SELECT Nome, Ano, Duracao FROM Filmes
WHERE Ano > 2000
```

### Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente

```sql
SELECT Nome, Ano, Duracao FROM Filmes
WHERE Duracao > 100 and Duracao < 150
ORDER BY Duracao
```

### Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente

```sql
SELECT Ano, COUNT(*) QUANTIDADE FROM Filmes
GROUP BY Ano
ORDER BY QUANTIDADE DESC
```

### Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome

```sql
SELECT * FROM Atores
WHERE Genero = 'M'
```

### Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome

```sql
SELECT * FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome
```

### Buscar o nome do filme e o gênero

```sql
SELECT 
    f.Nome AS Filme,
    g.Genero AS Genero
FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id
```

### Buscar o nome do filme e o gênero do tipo "Mistério"

```sql
SELECT 
    f.Nome AS Filme,
    g.Genero AS Genero
FROM Filmes f
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON fg.IdGenero = g.Id
WHERE g.Genero = 'Mistério'
```

### Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel

```sql
SELECT  f.Nome AS Filme, a.PrimeiroNome, a.UltimoNome, ef.Papel
FROM Filmes f
INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme
INNER JOIN Atores a ON ef.IdAtor = a.Id
```
