using calcium.api.Models;
using Microsoft.EntityFrameworkCore;

namespace calcium.api.Infrastructure.DataServices
{
	public class FarmerCosmosProvider
	{
		public FarmerCosmosProvider()
		{

		}


		public async Task<Farmer> CreateFarmer(Farmer entity)
		{
			return entity;
		}
	}


	public class FarmerCosmosDbContext : DbContext
	{
		public DbSet<Farmer> Farmers
		{ get; set; }

		public FarmerCosmosDbContext(DbContextOptions<FarmerCosmosDbContext> options)
		: base(options)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Farmer>().ToContainer("Farmer");
			modelBuilder.Entity<Farmer>().OwnsOne(x => x.Address);
		}
	}
}
