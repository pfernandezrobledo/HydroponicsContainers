using calcium.domain.Entities;

namespace calcium.infrastructure.DataServices
{
    public class FarmerDataService
    {
        private FarmerCosmosProvider cosmosProvider;
		private FarmerSqlProvider sqlProvider;

		public FarmerDataService()
        {
        }


        public async Task<Farmer> CreateFarmer(Farmer entity)
        {
			// CODE: Call the DBContext of the Farmer to save the entity and retrieve the saved entity as the retuned result
            //       If you implemented two providers, for example SQL and Cosmos, you would call both of them here

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

			return result;
		}
    }
}
