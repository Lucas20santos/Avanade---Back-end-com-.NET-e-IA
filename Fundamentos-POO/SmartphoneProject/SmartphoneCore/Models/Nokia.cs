using SmartphoneCore.Models;

namespace SmartphoneCore.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        public override Task InstalarAplicativoAsync(App app, IStorageService storageService)
        {
            Console.WriteLine($"\n[Nokia Store] Iniciando processo de download de {app.Nome}...");

            base.InstalarApp(app, storageService);

            return Task.CompletedTask;
        }
    }
}