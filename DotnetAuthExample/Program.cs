using DotnetAuthExample.AuthExampleDBContext;
using DotnetAuthExample.Interfaces;
using DotnetAuthExample.Repository;
using DotnetAuthExample.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AuthExampleContext>(options => options.UseSqlServer("name=ConnectionStrings:AuthExampleDB"));

builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
