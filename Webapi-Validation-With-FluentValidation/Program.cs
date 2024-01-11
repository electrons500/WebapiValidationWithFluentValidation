using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFluentValidation(o => o.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "FluentValidation",
            Description = "Web api with FluentValidation",
            Version = "v1",
            Contact = new OpenApiContact
            {
                Name = "Ishmael Kwaw Obeng",
                Email = "electrons500@gmail.com",
                Url = new Uri("https://www.linkedin.com/in/ishmael-obeng")
            },
            Extensions = new Dictionary<string, IOpenApiExtension>
            {
                  {"x-logo", new OpenApiObject
                    {
                       {"url", new OpenApiString("https://raw.githubusercontent.com/Redocly/redoc/master/docs/images/redoc-logo.png")},
                       { "altText", new OpenApiString("Your logo alt text here")}
                    }
                  }
            }
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
