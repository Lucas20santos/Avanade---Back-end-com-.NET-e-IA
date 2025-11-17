using Microsoft.EntityFrameworkCore;
using FundamentosWebApiMVC.Models;

namespace FundamentosWebApiMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        DbSet<Contato> Contatos { get; set; }
    }
}