// 1. Calcule a área de um retângulo pedindo a altura e a largura ao usuário.,
// "Variáveis, Conversão de Tipo (int.Parse ou Convert.ToInt32)"

void fibonacci(int atualA, int atualB, out int novoA, out int novoB)
{
    novoA = atualB;
    novoB = atualA + atualB;
}

int a = 0, b = 1;

fibonacci(a, b, out a, out b);
Console.WriteLine(a, b);

