# Código

## Explorando a linguagem csharp

### Classe Principal - Aula 01

```csharp
    namespace FundamentosProgramacaoObjeto
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Introdução: ->");
            }
        }
    }
```

### Classe Pessoa - Aula 01

```csharp
    namespace FundamentosProgramacaoObjeto.Models
{
    class Pessoa
    {
        private string _nome;
        private int _idade;
        public string? Nome
        {
            get { return _nome; }
            set
            {
                if (value == "") throw new ArgumentException("O nome não pode ser vazio.");
                _nome = value;
            }
        }
        public int idade
        {
            get { return _idade; }
            set {
                if (value < 0) throw new ArgumentException("Idade não pode recebe um valor negativo.");
                _idade = value;
            } 
        }

        public void apresentar()
        {
            Console.WriteLine($"Olá, me chamo {this._nome} e tenho {this._idade}.");
        }
    }
}
```

## Classe Curso

```csharp
    namespace FundamentosProgramacaoObjeto.Models
    {
        class Curso
        {
            public string? Nome { get; set; }
            public List<Pessoa> Alunos { get; set; }

            public void AdicionarAluno(Pessoa alunos)
            {
                Alunos.Add(alunos);
            }

            public int ObterQuantidadeDeAlunosMatriculados()
            {
                int quantidadeAlunos = Alunos.Count;
                return quantidadeAlunos;
            }
            public void RemoverAluno(Pessoa aluno)
            {
                Alunos.Remove(aluno);
            }
            public void ListarAlunos()
            {
                foreach (var item in Alunos)
                {
                    Console.WriteLine($"Aluno -> {item.Nome}");
                }
            }
        }
    }
```

## Leitura de um arquivo

```csharp
    string[] texto = File.ReadAllLines("./arquivo.txt");

    foreach (var item in texto)
    {
        Console.WriteLine(item);
    }
```

## Leitura de um arquivo com try catch

```csharp
    try
    {
        string[] texto = File.ReadAllLines("arquivoLeitura.txt");
        foreach (var item in texto)
        {
            Console.WriteLine(item);
        }
    }
    catch (DirectoryNotFoundException err)
    {
        Console.WriteLine("Diretório não encontrado, reveja o caminho passado: " + err.Message);
    }
    catch(FileNotFoundException err)
    {
        Console.WriteLine("Arquivo não encontrado ou não existe: " + err.Message);
    }
    catch (Exception err)
    {
        Console.WriteLine(err.Message);
    }
    finally
    {
        Console.WriteLine("Finalizando o processo.");
    }
```

## Usando o Throw

```csharp
    int a = 1;
    int b = 0;

    if (b == 0)
    {
        throw new Exception("Divisão por zero, não pode acontecer.");
    }
    else
    {
        Console.WriteLine($"{a / b}");
    }
```

Esse bloco lança uma excessão para ser tratada

## Coleções

### Queue ou FIFO - First In First Out

```csharp
Queue<int> fila = new Queue<int>();

            // adicionando elementos na fila
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);

            foreach (var item in fila)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            // removendo os elementos do primeiro ao ultimo na fila não se pode 
            // remover um item do meio ou ultimo
            fila.Dequeue();
            fila.Dequeue();
            fila.Dequeue();
            fila.Dequeue();
```

### Pilha ou Stack - LIFO - Last In First Out

```csharp
    Stack<int> pilha = new Stack<int>();

    // adicionando elementos na pilha
    pilha.Push(1);
    pilha.Push(2);
    pilha.Push(3);
    pilha.Push(4);

    // removendo elementos na pilha
    pilha.Pop();
    pilha.Pop();
    pilha.Pop();
    pilha.Pop();
```

### Dicionario

```csharp
    Dictionary<string, string> estado = new Dictionary<string, string>();
    estado.Add("PE", "Pernambuco");
    estado.Add("Ba", "Bahia");
    estado.Add("Mg", "Minas Gerais");
    estado.Add("Sp", "São Paulo");

    foreach (var item in estado)
    {
        Console.WriteLine(item);
    }
    foreach (KeyValuePair<string, string> item in estado)
    {
        Console.WriteLine(item);
    }
```
