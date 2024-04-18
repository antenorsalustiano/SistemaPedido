using Microsoft.EntityFrameworkCore;
using SistemaPedido.Data.Context;
using SistemaPedido.IoC;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectiongString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' n�o encontrada.");

builder.Services.AddDbContext<DBSqlContext>(opt => opt.UseSqlServer(connectiongString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


DependecyContainer.RegisterServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(option => option
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());;

app.UseAuthorization();

app.MapControllers();

app.Run();
