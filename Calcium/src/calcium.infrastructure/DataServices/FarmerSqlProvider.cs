using calcium.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace calcium.infrastructure.DataServices
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
			/* 
			NOTE: This code is to give you an idea of what the call to the db context will look
				  You still need to add the EF Core package to this project before you can use it

			await this.dbContext.Farmers.AddAsync(entity);
			await this.dbContext.SaveChangesAsync();
			var result = await this.dbContext.Farmers.FirstOrDefaultAsync(e => e.Code == entity.Code);
			return result;
			*/

			// CODE: Use the DB context to save the Farmer entity into SQL

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

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
