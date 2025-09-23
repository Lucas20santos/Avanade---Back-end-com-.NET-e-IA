using comum.Models;

namespace pricinpal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new()
            {
                Nome = "Lucas de Souza Santos",
                idade = 23
            };

            p1.apresentar();
        }
    }
}
