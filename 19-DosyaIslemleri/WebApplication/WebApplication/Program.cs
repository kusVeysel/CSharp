using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi;
using System.Reflection;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
// (swagger)
builder.Services.AddSwaggerGen(options =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
    // Tag(GroupName) işlemi
    options.TagActionsBy(api =>
    {
        if (api.GroupName != null)
            return new[] { api.GroupName };
        var controllerActionDescriptor = api.ActionDescriptor as ControllerActionDescriptor;
        if (controllerActionDescriptor != null)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }

        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });
    options.DocInclusionPredicate((name, api) => true);
    // Özelleştirme
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "VEYSEL",
        Version = "v1",
        Description = "Net10 ile üretilen API Servis",
        Contact = new OpenApiContact
        {
            Name = "Veysel",
            Url = new Uri("https://www.github.com/kusVeysel"),
            Email = "kusveysel01@gmail.com"
        }
    });

});

// Dosya İşlemleri
builder.WebHost.ConfigureKestrel(o =>
{
    o.Limits.MaxRequestBodySize = 200_000_000; // 200mb
});

builder.Services.Configure<FormOptions>(o =>
{
    o.MultipartBoundaryLengthLimit = 200_000_000; // 200mb
    o.ValueLengthLimit = 1 * 1024 * 1024; // 1mb
    o.MultipartHeadersLengthLimit = 64 * 1024; // 64kb
});


builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
