using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calcium.api.Application;
using calcium.api.Infrastructure.DataServices;
using calcium.api.Models;
using calcium.domain.Interfaces.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Serialization.HybridRow;

namespace calcium.api
{
	[Route("api/[controller]")]
	[ApiController]
	public class FarmerController : ControllerBase
	{
		private IFarmerAppService farmerService;

		public FarmerController(IFarmerAppService farmerService)
		{
			// CODE: Configure the dependency injection for IFarmerService so that it resolves to a scoped instance of FarmerAppService
			// CODE: Set 'farmerService' of this instance to the 'farmerService' sent as the input in this constructior			
		}


		[HttpPost(Name = "CreateFarmer")]
		public async Task<ActionResult<Farmer>> CreateFarmer([FromBody] Farmer entity)
		{
			// CODE:Validate the input entity's properties

			// CODE: Call CreateFarmer on the IFarmerAppService

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

			// CODE: Handle any unexpected or application errors and return a friendly status message.

			return CreatedAtRoute("GetFarmer", new { code = result.Code }, result);
		}

		[HttpGet("{code}", Name = "GetFarmer")]
		public async Task<ActionResult<Farmer>> GetFarmer(string code)
		{
			// CODE:Validate the input

			// CODE: Call GetFarmer on the IFarmerAppService (You will need to implement it)

			// CODE: Set the 'result' to the returned Farmer entity 
			var result = new Farmer();

			// CODE: Handle any unexpected or application errors and return a friendly status message.

			return new JsonResult(result);
		}

	}
}
