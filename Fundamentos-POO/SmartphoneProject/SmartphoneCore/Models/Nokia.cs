namespace SmartphoneCore.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        public override Task InstalarAplicativoAsync(App app, IStorageService storageService)
        {
            Console.WriteLine("Instlaando o aplicativos {app.Nome} no Nokia");
            return Task.CompletedTask;
        }
    }
}