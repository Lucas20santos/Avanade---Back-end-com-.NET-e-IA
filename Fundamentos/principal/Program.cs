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
