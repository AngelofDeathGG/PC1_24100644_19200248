using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;
using UESAN.GESTIONTALLER.CORE.Core.Interfaces;
using UESAN.GESTIONTALLER.CORE.Core.Services;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TallerDbContext>();
builder.Services.AddTransient<IOrdenServicioRepository, OrdenServicioRepository>();
builder.Services.AddTransient<IOrdenServicioService, OrdenServicioService>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
