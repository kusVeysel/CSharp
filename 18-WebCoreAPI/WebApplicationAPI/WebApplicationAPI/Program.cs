using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApplicationAPI;
using WebApplicationAPI.Repository;
using WebApplicationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); // IGenericRepository çağrılan yerde GenericRepository getir.
builder.Services.AddScoped<IProductService, ProductService>(); // IProductService çağrılan yerde ProductService getir.
builder.Services.AddAuthorization(); // Authorization, kullanıcıların belirli kaynaklara erişimini kontrol etmek için kullanılır. Kullanıcıların kimlik doğrulaması yapıldıktan sonra hangi kaynaklara erişebileceğini belirler.
builder.Services.AddSingleton<JWTService>(); // JWTService sınıfını singleton olarak kaydeder. Bu, uygulama boyunca tek bir örneğin kullanılmasını sağlar.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var key = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            // Token doğrulama parametrelerini ayarlar. Bu, JWT'nin geçerliliğini kontrol etmek için kullanılır.
            ClockSkew = TimeSpan.Zero, // Jwt token geçerliliği için 5dk daha tolerans verir bu metotla bu engellenir, sadece bizim tanımladığımız kadar.
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        }; // Token doğrulama parametrelerini ayarlar. Bu, JWT'nin geçerliliğini kontrol etmek için kullanılır.
    }); // Token tabanlı kimlik doğrulama için JWT Bearer kullanır. Bu, kullanıcıların JWT tokenlerini kullanarak kimlik doğrulaması yapmasını sağlar.

// Bundan öncesi, proje çalışmadan önce neler olması gerektiğini söyler.
var app = builder.Build();
// Bundan sonrası, proje çalışırken neler ile beraber çalışmalı olması gerektiğini söyler.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthentication(); // Kimlik doğrulama işlemlerini etkinleştirir. Bu, kullanıcıların kimlik doğrulaması yapmasını sağlar.
app.UseAuthorization();

app.MapControllers();

app.Run();
