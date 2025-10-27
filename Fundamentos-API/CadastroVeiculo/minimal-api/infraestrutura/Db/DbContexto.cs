using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;
using Microsoft.Extensions.Configuration;
// Adicionado: Using essencial para o método UseMySql
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; 
using Pomelo.EntityFrameworkCore.MySql;
using System; // Para o método String.IsNullOrEmpty
using System.Linq; // Para o método Any no OnConfiguring

namespace minimal_api.infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configurationAppSettins;

        // CONSTRUTOR PADRÃO EF CORE: ESSENCIAL PARA O COMANDO 'dotnet ef' FUNCIONAR
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
            // Este construtor é usado quando o contexto é configurado via Program.cs
        }

        // CONSTRUTOR ADICIONAL: Para injetar IConfiguration
        public DbContexto(IConfiguration configurationAppSettins)
        {
            _configurationAppSettins = configurationAppSettins;
        }

        // CORREÇÃO: Deve ser DbSet<T> e não Db<T>. Nome comum no plural.
        public DbSet<Administrador> Administradores { get; set; } = default!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // CORREÇÃO: O EF Core CLI (dotnet ef) usa o construtor 'options' e já configura,
            // então, só executamos este código se não estiver configurado.
            if (!optionsBuilder.IsConfigured)
            {
                // Verifica se a configuração foi injetada (apenas se usarmos o construtor IConfiguration)
                if (_configurationAppSettins != null)
                {
                    var stringConexao = _configurationAppSettins.GetConnectionString("mysql");
                    
                    // CORREÇÃO: Usando a função estática correta para verificar string nula ou vazia.
                    if (!string.IsNullOrEmpty(stringConexao))
                    {
                        // O ServerVersion.AutoDetect é para o provedor Pomelo
                        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
                    }
                }
                else
                {
                    // Se não foi configurado e não temos o IConfiguration, o EF CLI falhará aqui
                    // A melhor prática é configurar no Program.cs
                    throw new InvalidOperationException(
                        "O contexto deve ser configurado ou injetado via DbContextOptions para o 'dotnet ef' funcionar."
                    );
                }
            }
        }
    }
}