

namespace MinhasTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descicao { get; set; }
        public DateTime Date { get; set; }
        public StatusTarefa Status { get; set; }
    }
}