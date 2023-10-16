using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tp3_Antoine_Bouchard.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Tp3_Antoine_BouchardContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Tp3_Antoine_BouchardContext") ?? throw new InvalidOperationException("Connection string 'Tp3_Antoine_BouchardContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
