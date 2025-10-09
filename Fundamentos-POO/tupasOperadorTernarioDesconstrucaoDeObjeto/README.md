# Tuplas, Operador Ternário e Desconstrução de Objetos

## Tuplas

### Declarando uma tupla

```csharp
    // Declarando uma tupla
    (int, string, string, decimal) tupla = (1, "Lucas", "Santos", 1.67M);
    // Outra maneira
    (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Santos");

    //Imprimindo valores:
    Console.WriteLine($"Idade: {tupla.Item1}");
    Console.WriteLine($"Nome: {tupla.Item2}");
    Console.WriteLine($"Sobrenome: {tupla.Item3}");
    Console.WriteLine($"Altura: {tupla.Item4}");
```

### Outra sintaxe de tupla

```csharp
    // Declarando uma tupla
    ValueTuple<int, string, string, decimal> outraTupla = (1, "Maria", "Souza", 1.65M);
    Console.WriteLine($"Idade: {outraTupla.Item1}");
    Console.WriteLine($"Nome: {outraTupla.Item2}");
    Console.WriteLine($"Sobrenome: {outraTupla.Item3}");
    Console.WriteLine($"Altura: {outraTupla.Item4}");

```

### Retornando uma tupla como retorno de um método

```csharp
namespace tupasOperadorTernarioDesconstrucaoDeObjeto
{

    class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int quantLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] texto = File.ReadAllLines(caminho);
                return (true, texto, texto.Count());
            }
            catch (System.Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}
// Programa principal
using tupasOperadorTernarioDesconstrucaoDeObjeto;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, texto, quantLinhas) = arquivo.LerArquivo("./arquivo.txt");

if (sucesso)
{
    foreach (var item in texto)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo.");
}

```
