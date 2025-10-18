namespace SmartphoneCore.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; protected set; }
        public string Modelo { get; protected set; }
        public
        string IMEI
        { get; protected set; }
        public int Memoria { get; protected set; }
        private readonly List<App> _aplicativosInstalados;
        public IReadOnlyList<App> AplicativosInstalados => _aplicativosInstalados;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            string textException = "Por favor não passar um argumento nulo ou vazio.";
            string textExceptionNumber = "Por favor não passar um valor fora do intervalo";

            if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException(textException);
            if (string.IsNullOrWhiteSpace(modelo)) throw new ArgumentException(textException);
            if (stringIsNullOrWhiteSpace(imei)) throw new ArgumentException(textException);
            if (memoria <= 0) throw new ArgumentOutOfRangeException(textExceptionNumber);

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine($"{Modelo} está ligando.");
        }
        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"O {Modelo} está recebendo ligação do número {numero}.");
        }
        public void ListarAplicativos()
        {
            foreach (var item in _aplicativosInstalados)
            {
                Console.WriteLine("App Instalados");
                if (_aplicativosInstalados.Count == 0)
                {
                    Console.WriteLine("Nenhum app instalado");
                    return;
                }
                foreach (var app in _aplicativosInstalados)
                {
                    Console.WriteLine($"{app.Nome} - {app.Versao} - {app.TamanhoEmMb}");
                }
            }
        }
        public abstract Task InstalarAplicatiovsAsync(App app);
    }
}