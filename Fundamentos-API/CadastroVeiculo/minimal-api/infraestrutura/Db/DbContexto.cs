using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;

namespace minimal_api.infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configurationAppSettins;
        public DbContexto(IConfiguration configurationAppSettins)
        {
            _configurationAppSettins = configurationAppSettins;
        }
        public Db<Administrador> administrador { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = _configurationAppSettins.GetConnectionString("mysql")?.ToString();
            if (!stringConexao.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
            }
            else
            {
                
            }
        }
    }
}