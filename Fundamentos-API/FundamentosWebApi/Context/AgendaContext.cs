using FundamentosWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FundamentosWebApi.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }
        public DbSet<Contato> Contatos { get; set; }        
    }
}