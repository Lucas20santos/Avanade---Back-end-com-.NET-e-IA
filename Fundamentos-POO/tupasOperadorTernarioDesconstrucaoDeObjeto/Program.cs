using tupasOperadorTernarioDesconstrucaoDeObjeto;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, texto, quantLinhas) = arquivo.LerArquivo("./arquivo.txt");

if (sucesso)
{
    foreach (var item in texto)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo.");
}
