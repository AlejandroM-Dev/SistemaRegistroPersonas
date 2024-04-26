using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.OpenApi.Models;
using SistemaRegistroPersonas.BLL.Service;
using SistemaRegistroPersonas.DAL.DataContext;
using SistemaRegistroPersonas.DAL.Repositories;
using SistemaRegistroPersonas.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbRegistroPruebaContext>(opciones =>{
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

//inyeccion de dependencias
builder.Services.AddScoped<IGenericRepository<RegistroPersona>, RegistroRepository>();
builder.Services.AddScoped<IRegistroPersonasService, RegistroPersonasService>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();
// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
app.UseSwaggerUI();
app.MapControllers();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
