using calcium.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace calcium.infrastructure.DataServices
{
	public class FarmerCosmosProvider
	{
		public FarmerCosmosProvider()
		{

		}


		public async Task<Farmer> CreateFarmer(Farmer entity)
		{
			// CODE: Use the DB context to save the Farmer entity into SQL

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

			return result;
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
