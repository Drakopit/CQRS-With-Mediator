using CQRS.Domain.Commands;
using CQRS.Domain.Products;
using CQRS.Infra;
using CQRS.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
    // InMemory
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("ProductDb"));
    // SQLite
// builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=products.db"));

// Mediator
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(CreateProductCommand))));

// The Product Reository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
