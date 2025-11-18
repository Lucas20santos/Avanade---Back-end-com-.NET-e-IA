// 1. Calcule a área de um retângulo pedindo a altura e a largura ao usuário.,
// "Variáveis, Conversão de Tipo (int.Parse ou Convert.ToInt32)"

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

Console.WriteLine($"Área = Altura x Largura = {altura * largura}");
