using AglixBackend.Domain.Interfaces;
using AglixBackend.Infrastructure.Data;
using AglixBackend.Application.Interfaces;
using AglixBackend.Application.Services;
using Microsoft.EntityFrameworkCore;
using AglixBackend.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins("https://localhost:7223", "http://localhost:5246") 
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAgileRepository, AgileRepository>();
builder.Services.AddScoped<IAgileService, AgileService>();
builder.Services.AddScoped<IAgileImplementationService, AgileImplementationService>();
builder.Services.AddScoped<IAgileImplementationRepository, AgileImplementationRepository>();
builder.Services.AddScoped<IAgileImplementationElementService, AgileImplementationElementService>();
builder.Services.AddScoped<IAgileImplementationElementRepository, AgileImplementationElementRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigins"); 

app.UseAuthorization();

app.MapControllers();

app.Run();
