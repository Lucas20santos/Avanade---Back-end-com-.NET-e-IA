# Solução

## Exercicio 1

```cs
    Console.WriteLine("Hello, c# World!");
```

## Exercicio 2

```cs
    int num1 = 10;
    int num2 = 20;

    Console.WriteLine(num1 + num2);
```

## Exercicio 3

```cs
// 1. "Peça ao usuário que digite seu nome e, em seguida, cumprimente-o usando o nome.","Console.ReadLine(), Concatenação"

    Console.WriteLine("Digite seu nome: ");
    string? nome = Console.ReadLine();

    Console.WriteLine("Prazer em conhecer você " + nome);
```

## Exercicio 4

### Primeira solução 4.1

```cs
    Console.WriteLine("Informe a altura de um retangulo: ");
    double? altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Infrome a largura do mesmo retangulo: ");
    double? largura = double.Parse(Console.ReadLine());

    Console.WriteLine($"Area = Largura x Altura = {altura * largura}");
```

> Essa solução pode gerar uma resalva:

```bash
    warning CS8604: Possível argumento de referência nula para o parâmetro 's' em 'double double.Parse(string s)'.
    warning CS8604: Possível argumento de referência nula para o parâmetro 's' em 'double double.Parse(string s)'.
```

### Segunda Solução 4.2

```cs
    Console.WriteLine("Informe a altura de um retângulo: ");
    if (!double.TryParse(Console.ReadLine(), out double altura))
    {
        Console.WriteLine("Valor inválido para altura!");
        return;
    }

    Console.WriteLine("Informe a largura do retângulo: ");
    if (!double.TryParse(Console.ReadLine(), out double largura))
    {
        Console.WriteLine("Valor inválido para largura!");
        return;
    }

    Console.WriteLine($"Área = {altura * largura}");
```

- ```out double largura``` ou ```out double largura``` pega o valor digitado de Console.ReadLine()

### Exemplo de com 'out'

```cs
double Divisao(double a, double b, out double resto, out string mensagem)
{
    if (b == 0)
    {
        mensagem = "Divisao Por Zero";
        resto = a;
        return 0;
    }
    else
    {
        resto = a % b;
        mensagem = "ok";
        return a / b;
    }
}

double num1 = 10;
double num2 = 3;
string mens;
double r;
double quociente = Divisao(num1, num2, out r, out mens);

if (mens == "ok")
{
    Console.WriteLine("Resultado: ");
    Console.WriteLine($"Quociente = {quociente}, Resto = {r}, mensagem = {mens}");
}
```
