namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2) => num1 + num2;
        public int Subtrair(int num1, int num2) => num1 - num2;
        public int Multiplicar(int num1, int num2) => num1 * num2;
        public double Dividir(double num1, double num2) => num2 == 0.0 ? 0.0: num1 / num2;
        public bool EPar(int num) => num % 2 == 0;
    }
}