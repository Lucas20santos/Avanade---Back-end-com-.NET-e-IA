namespace tupasOperadorTernarioDesconstrucaoDeObjeto
{
    
    class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int quantLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] texto = File.ReadAllLines(caminho);
                return (true, texto, texto.Count());
            }
            catch (System.Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}