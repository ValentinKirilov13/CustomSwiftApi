using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Models;
using CustomSwiftApi.Infrastructure.Repositories;
using CustomSwiftApi.Service.Contracts;
using CustomSwiftApi.Service.Services;
using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(provider =>
{
    string connectionString = builder.Configuration.GetConnectionString("SQLiteConnectionString") ?? string.Empty;
    return new SqliteConnection(connectionString);
});
builder.Services.AddScoped<IRepository<SwiftMessage>, SwiftMessageRepository>();
builder.Services.AddScoped<ISwiftMessageService, SwiftMessageService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
