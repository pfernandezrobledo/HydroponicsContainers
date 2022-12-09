using calcium.api.Models;
using Microsoft.EntityFrameworkCore;

namespace calcium.api.Infrastructure.DataServices
{
	public class FarmerSqlProvider
	{
		private FarmerSqlDbContext dbContext;

		public FarmerSqlProvider(FarmerSqlDbContext dbContext)
		{
			this.dbContext = dbContext;

		}

		public async Task<Farmer> CreateFarmer(Farmer entity)
		{

			await this.dbContext.Farmers.AddAsync(entity);

			await this.dbContext.SaveChangesAsync();

			var result = await this.dbContext.Farmers.FirstOrDefaultAsync(e => e.Code == entity.Code);

			return result;
		}
	}


	public class FarmerSqlDbContext : DbContext
	{
		public DbSet<Farmer> Farmers
		{ get; set; }

		public FarmerSqlDbContext(DbContextOptions<FarmerSqlDbContext> options)
		: base(options)
		{
			Database.EnsureCreated();
		}		 
	}
}
