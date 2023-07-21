using Domain_Driven_Design__DDD_.Application.Productos;
using Domain_Driven_Design__DDD_.Domain.Repositories;
using Domain_Driven_Design__DDD_.Domain.Services;
using Domain_Driven_Design__DDD_.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

builder.Services.AddDbContext<YourDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("YourDbContext"));
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    build.WithHeaders("*");
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();

}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
