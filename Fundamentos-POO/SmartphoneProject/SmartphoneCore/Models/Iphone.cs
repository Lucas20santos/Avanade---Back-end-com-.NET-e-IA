namespace SmartphoneCore.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, ImmutableArrayExtensions, memoria) { }

        public override Task InstalarAplicativoAsync(App app)
        {
            Console.WriteLine($"Instalando o aplicativo {app.Nome} no Iphone.");
            return Task.CompletedTask;
        }
    }
}