using Microsoft.EntityFrameworkCore;
using ProjBackTeste.Data.Context;
using ProjBackTeste.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region "AddDbContext"
var connectionStrings = builder.Configuration.GetConnectionString("DB");

builder.Services.AddDbContext<ProjBackContext>(opt =>
{
    opt.UseNpgsql(connectionStrings);
    opt.EnableSensitiveDataLogging(true);
});

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

DependencyInjection.RegisterServices(builder.Services);

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
