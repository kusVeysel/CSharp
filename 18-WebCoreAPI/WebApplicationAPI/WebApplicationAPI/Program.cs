using Microsoft.EntityFrameworkCore;
using WebApplicationAPI;
using WebApplicationAPI.Repository;
using WebApplicationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); // IGenericRepository çağrılan yerde GenericRepository getir.
builder.Services.AddScoped<IProductService, ProductService>(); // IProductService çağrılan yerde ProductService getir.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Bundan öncesi, proje çalışmadan önce neler olması gerektiğini söyler.
var app = builder.Build();
// Bundan sonrası, proje çalışırken neler ile beraber çalışmalı olması gerektiğini söyler.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
