// Importe essa duas pastas aqui
using Microsoft.EntityFrameworkCore;
using ApiTarefaMVC.Context;

var builder = WebApplication.CreateBuilder(args);

// // Adicionar serviço DbContext (INÍCIO DA CONFIGURAÇÃO)
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);
// // Adicionar serviço DbContext (FIM DA CONFIGURAÇÃO)


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
