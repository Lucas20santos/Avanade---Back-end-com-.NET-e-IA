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

## Manipulação de Valores

### Classe Princiapa - Aula 02

### Classe Pessoa - Aula 02

### Clase Curso - Aula 02
