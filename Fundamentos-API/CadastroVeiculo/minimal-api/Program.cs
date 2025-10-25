using minimal_api.Dominio.DTOs;
class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<DbContexto>();

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        // Criando uma rota para validar o login
        app.MapPost("/login", (LoginDTO loginDTO) =>
        {
            if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
            {
                return Results.Ok("Login com sucesso");
            }
            else
            {
                return Results.Unauthorized();
            }
        });
        
        app.Run();
    }
}
