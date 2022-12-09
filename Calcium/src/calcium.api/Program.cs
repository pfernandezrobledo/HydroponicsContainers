using calcium.api.Infrastructure.DataServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FarmerSqlDbContext>(o =>
{
	o.UseSqlServer(builder.Configuration["Database:MSSql:ConnectionString"]);
});

builder.Services.AddDbContext<FarmerCosmosDbContext>(o =>
{
#pragma warning disable CS8604 // Possible null reference argument.
	o.UseCosmos(builder.Configuration["Database:Cosmos:AccountEndpoint"],
				builder.Configuration["Database:Cosmos:AccountKey"],
				builder.Configuration["Database:Cosmos:DatabaseName"]);
#pragma warning restore CS8604 // Possible null reference argument.
});

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
