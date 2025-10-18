namespace SmartphoneCore.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        public override Task InstalarAplicativoAsync(App app, IStorageService storageService)
        {
            Console.WriteLine($"Instalando o aplicativo {app.Nome} no Iphone.");
            return Task.CompletedTask;
        }
    }
}