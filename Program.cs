using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<AngularProjectContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddTransient<HomeInterface,HomeService>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
