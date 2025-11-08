using Microsoft.EntityFrameworkCore;
using MinhasTarefas.Models;

namespace MinhasTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        // Contrutor que recebe as opções do DbContext
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}