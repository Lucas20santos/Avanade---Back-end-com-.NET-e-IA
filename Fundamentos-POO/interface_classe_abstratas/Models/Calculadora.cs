using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interface_classe_abstratas.Interfaces;

namespace interface_classe_abstratas.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2) => num1 + num2;
        public int Multiplicar(int num1, int num2) => num1 - num2;
        public int Somar(int num1, int num2) => num1 * num2;
        public int Subtrair(int num1, int num2) => num1 != 0 ? num1 / num2 : 0;
    }
}