using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefaMVC.Models;

// Insira a clausura do Microsoft.EntityFrameworkCore para poder usar o DbContext
using Microsoft.EntityFrameworkCore;

namespace ApiTarefaMVC.Context
{
    // A classe deve herdade de DbContext
    public class OrganizadorContext : DbContext
    {
        // Contrutor obrigatório para a injeção de dependência
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }
        //DbSet: Representa a tabela no banco de dados
        // A tabela será chamada 'Tarefas' (plural do nome da classe)
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}