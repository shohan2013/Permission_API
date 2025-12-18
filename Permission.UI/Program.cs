using Microsoft.AspNetCore.Mvc;
using Permission.Api;
using Permission.Api.Controllers.Employee;
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers()
    .AddApplicationPart(typeof(EmployeeController).Assembly)
    .AddControllersAsServices();

// Swagger (choose ONE)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddAppDI();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>      // Serves Swagger UI page
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Makes Swagger UI available at root "/"
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
