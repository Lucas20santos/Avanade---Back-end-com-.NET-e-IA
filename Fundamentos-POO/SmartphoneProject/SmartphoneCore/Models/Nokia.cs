namespace SmartphoneCore.Models
{
    public class Nokia : Smartphore
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
               : base(numero, modelo, imei, memoria)
        {

        }
        
        public override Task InstalarAplicativoAsync(App app)
        {
            Console.WriteLine("Instlaando o aplicativos {app.Nome} no Nokia");
            return Task.CompletedTask;
        }
    }
}