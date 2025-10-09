// Declarando uma tupla
(int, string, string, decimal) tupla = (1, "Lucas", "Santos", 1.67M);



//Imprimindo valores:
Console.WriteLine($"Idade: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");


// Outra maneira de criar uma tupla
ValueTuple<int, string, string, decimal> outraTupla = (1, "Maria", "Souza", 1.65M);
Console.WriteLine($"Idade: {outraTupla.Item1}");
Console.WriteLine($"Nome: {outraTupla.Item2}");
Console.WriteLine($"Sobrenome: {outraTupla.Item3}");
Console.WriteLine($"Altura: {outraTupla.Item4}");
