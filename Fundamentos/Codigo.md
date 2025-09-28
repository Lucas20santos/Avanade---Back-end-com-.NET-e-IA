# Códigos

## Array no dotnet csharpe

```csharp
    using comum.Models;

    Pessoa p1 = new()
    {
        Nome = "Lucas de Souza Santos",
        idade = 23
    };

    p1.apresentar();

    Console.WriteLine("Final");

    int[] arrayInt1 = { 1, 2, 3, 4, 5, 6, 7 };
    int[] arrayInt2 = new int[4];
    int[] arrayInt3 = new int[] { 1, 2, 3, 4 };
    int[] arrayInt4 = new int[7];

    Console.WriteLine("A array 1 Imprimindo: ");
    for (int i = 0; i < arrayInt1.Length; i++)
    {
        Console.Write(arrayInt1[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Acessando array 2: ");
    foreach (var item in arrayInt2)
    {
        Console.Write(item + " ");   
    }
    Console.WriteLine();
    Console.WriteLine("Acessando o array 3: ");
    int cont = 0;
    while (cont < arrayInt3.Length)
    {
        Console.Write(arrayInt3[cont]);
        cont++;
    }
    Console.WriteLine();

    // Eu quero reedimensionar o meu arrayInt2
    Array.Resize(ref arrayInt2, 6);

    // Copiando os valores do arrayInt1 para um arrayInt4
    Array.Copy(arrayInt1, arrayInt4, arrayInt1.Length);

    Console.WriteLine("Acessando array 4: ");
    foreach (var item in arrayInt4)
    {
        Console.Write(item + " ");   
    }
    Console.WriteLine();

```

## List

```csharp
    List<string> listString = new List<string>();

    listString.Add("São Paulo");
    listString.Add("Pernambuco");

    Console.WriteLine(listString);

    foreach (var item in listString)
    {
        Console.WriteLine(item);
    }
```

## Projeto

```csharp
class Estacionamentos
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        // *IMPLEMENTE AQUI*
        Console.WriteLine("Digite a placa do veículo para estacionar:");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");

        // Pedir para o usuário digitar a placa e armazenar na variável placa
        // *IMPLEMENTE AQUI*
        string placa = "";

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            // *IMPLEMENTE AQUI*
            int horas = 0;
            decimal valorTotal = 0; 

            // TODO: Remover a placa digitada da lista de veículos
            // *IMPLEMENTE AQUI*

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            // *IMPLEMENTE AQUI*
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
```
