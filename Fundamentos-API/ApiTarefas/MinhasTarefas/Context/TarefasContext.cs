using Microsoft.EntityFrameworkCore;
using MinhasTarefas.Models;

namespace MinhasTarefas.Context
{
    public class TarefasContext : DbContext
    {
        // Contrutor que recebe as opções do DbContext
        public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;
    }
}