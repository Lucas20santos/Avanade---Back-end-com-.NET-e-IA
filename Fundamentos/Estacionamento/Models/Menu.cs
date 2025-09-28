namespace Estacionamento.Models
{
    class Menu
    {
        Custo c1 = new Custo();
        public void apresentar()
        {
            Console.WriteLine("Informações Básicas: ");
            Console.WriteLine($"Preço Fixo do estacionamento: {c1.PRECOFIXO}");
            Console.WriteLine($"Preço Por Hora do Estacionamento: {c1.PRECOPORHORA}");
            Console.WriteLine("Pressione Enter para Continuar -> ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1 - Adicionar Veiculo");
            Console.WriteLine("2 - Remover Veiculo");
            Console.WriteLine("3 - Listar Veiculos");
            Console.WriteLine("4 - Encerrar");
            Console.ReadLine();
            Console.Clear();
        }
    }    
}