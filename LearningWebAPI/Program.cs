using LearningWebAPI.Database;
using LearningWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

string? con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<StudentContext>(builder =>
{
    builder.UseSqlServer(con).EnableSensitiveDataLogging();
});
// Add services to the container.
builder.Services.TryAddScoped<Istudent, studentImplementaion>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
