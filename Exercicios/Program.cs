// 1. Calcule o dobro de um número fornecido pelo usuário.,"Variáveis, Multiplicação"

Console.WriteLine("Informe o número: ");

string? leitura = Console.ReadLine();

if(!double.TryParse(leitura, out double numero))
{
    Console.WriteLine("Valor inválido para numero");
    return;
}

Console.WriteLine($"O dobro de {numero} é {2 * numero}");
