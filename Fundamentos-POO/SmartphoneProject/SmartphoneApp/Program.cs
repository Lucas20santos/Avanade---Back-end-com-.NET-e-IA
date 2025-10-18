using SmartphoneCore.Services;
using SmartphoneCore.Models;

public class Program
{
    public static async Task Main(string[] args)
    {
        var storageService = new StorageService();
        var appStoreService = new AppStoreService();

        // NOKIA com memória alta
        var nokia = new Nokia("99999-0000", "Nokia Tijolão", "111111", 512);

        // IPHONE com memória baixa para forçar 'Memória Insuficiente'
        var iphone = new Iphone("98888-0000", "iPhone 4S", "222222", 64);

        Console.WriteLine("\n--- Cenário 1: Nokia (Instalação de Sucesso) ---");
        nokia.Ligar();
        // O AppStoreService simulará um app de 30MB
        await appStoreService.DownloadAppAsync(nokia, "WhatsApp", storageService); 
        nokia.ListarAplicativos();
    }
}