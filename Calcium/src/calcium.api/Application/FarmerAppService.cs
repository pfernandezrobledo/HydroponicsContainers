using calcium.api.Infrastructure.DataServices;
using calcium.api.Models;

namespace calcium.api.Application
{
    public class FarmerAppService
	{
		private FarmerDataService farmerDataService;


		public FarmerAppService()
		{
			this.farmerDataService = new FarmerDataService();
		}


		public async Task<Farmer> CreateFarmer(Farmer entity)
		{
			/*	
			NOTE: 
			Why are we setting the 'Code' in the App Service and the 'ID' in the Data Service ?

			The ID is a concept tightly related to storage, and it's used to identify a single row or document in the database; 
			we don't usuall comunicate this ID withthe front end becasue in the context of the UI or UX, the ID has no meaning to the user.

			The CODE is a concept related tot he application, and like the ID it's used for identification, but in this case the CODE identifies an Entity,
			which might map to more than one row or document.  We also expect to use this CODE on the UI to allow the user to identify the entity in the UI 
			and to use it in routing or other actions that the user might want to take on the entity.
			*/

			// entity.Id = Guid.NewGuid();			
			entity.Code = Guid.NewGuid().ToString("N").Substring(0, 7);

			var result = await this.farmerDataService.CreateFarmer(entity);

			return result;
		}
	}
}
