using SmartphoneCore.Models;

namespace SmartphoneCore.Services
{
    public interface IAppStoreService
    {
        Task DownloadAppAsync(Smartphone smartphone, string nomeApp, IStorageService storageService);
    }
}