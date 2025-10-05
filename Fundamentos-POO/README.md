# Códigos

```csharp
    Console.WriteLine("Hello, World");
```

## Introdução ao Módulo

```csharp
    Console.WriteLine("Hello, World");
```

## Introdução Propriedades e Propriedades práticas

### Classe Pessoa

```csharp
    namespace FundamentosProgramacaoObjeto.Models
    {
        class Pessoa
        {
            public string? Nome { get; set; }
            public int idade { get; set; }

            public void apresentar()
            {
                Console.WriteLine($"Olá, me chamo {this.Nome} e tenho {this.idade}.");
            }
        }
    }
```

### Classe principal

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

## Criando um método

```csharp
    Console.WriteLine("Hello, World");
```

## Validações no GET e SET

```csharp
    namespace FundamentosProgramacaoObjeto.Models
    {
        class Pessoa
        {
            private string? _nome;
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

## Body Expression

```csharp
    Console.WriteLine("Hello, World");
```

## Validando a propriedade idade

```csharp
    Console.WriteLine("Hello, World");
```

## Modificadores de acesso

```csharp
    Console.WriteLine("Hello, World");
```

## Propriedades somente de leitura

```csharp
    Console.WriteLine("Hello, World");
```

## Introdução ao métodos

```csharp
    Console.WriteLine("Hello, World");
```

## Implementando a classe curso

```csharp
    Console.WriteLine("Hello, World");
```

## Tipos de retorno

```csharp
    Console.WriteLine("Hello, World");
```

## Implementando o método Remover

```csharp
    Console.WriteLine("Hello, World");
```

## Implementando o método listar alunos

```csharp
    Console.WriteLine("Hello, World");
```

## Trabalhando com construtores

```csharp
    Console.WriteLine("Hello, World");
```

## Inplementando construtor

```csharp
    Console.WriteLine("Hello, World");
```

## Finalizando
