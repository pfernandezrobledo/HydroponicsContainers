using calcium.domain.Entities;
using calcium.domain.Interfaces.Infrastructure;

namespace calcium.application
{
	// CODE: Implement the interface for this class from the domain.Interfaces namespace
	// CODE: Configure the dependency injection for IFarmerDataService so that it resolves to a scoped instance of FarmerDataService
	public class FarmerAppService
	{
		private IFarmerDataService farmerDataService;


		public FarmerAppService(IFarmerDataService farmerDataService)
		{

			// CODE: Set 'farmerDataService' of this instance to the 'farmerDataService' sent as the input in this constructior	
		}


		public async Task<Farmer> CreateFarmer(Farmer entity)
		{
			// CODE: Execute business validations.  These are the validations that require access to the data source.
			//       These are not validating the properties, that should have been done on the APi layer


			// CODE: Call CreateFarmer on the IFarmerAppService

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

			return result;
		}
	}
}
