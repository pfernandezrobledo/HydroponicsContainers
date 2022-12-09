using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calcium.api.Application;
using calcium.api.Infrastructure.DataServices;
using calcium.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace calcium.api
{
	[Route("api/[controller]")]
	[ApiController]
	public class FarmerController : ControllerBase
	{
		private FarmerSqlDbContext farmerSqlDbContext;
		private FarmerCosmosDbContext farmerCosmosDbContext;
		private FarmerAppService farmerService;

		public FarmerController(FarmerSqlDbContext farmerSqlDbContext, FarmerCosmosDbContext farmerCosmosDbContext)
		{
			/*
			NOTE: For the first version we will send the DB Context in the controller, to do a Controller to DB call.
			When we update the project to use contracts/interfaecs and Dependency Injection, we will allow all references to be injected according to the clean arch design
			
			*/
			this.farmerSqlDbContext = farmerSqlDbContext;
			this.farmerCosmosDbContext = farmerCosmosDbContext;

			this.farmerService = new FarmerAppService();
		}


		[HttpPost(Name = "CreateFarmer")]
		public async Task<ActionResult<Farmer>> CreateFarmer([FromBody] Farmer entity)
		{
			// Validate the entity's properties

			// We don't really need to validate the http method, asp.net middleware should take care of returning a HTTP 405 Method Not Allowed

			// Call the application or infrastructure component.  Preferably the app layer first

			// ??? var result = await farmerService.CreateFarmer(entity);

			this.farmerSqlDbContext.Farmers.Add(entity);
			this.farmerSqlDbContext.SaveChanges();

			this.farmerCosmosDbContext.Farmers.Add(entity);

			this.farmerCosmosDbContext.SaveChanges();

			// Handle any unexpected or application errors and return a friendly status message

			// If the operaion succeeds, then return the created farmer entity.

			return CreatedAtRoute("GeFarmer", new { code = entity.Code }, entity);
		}

		[HttpGet("{code}", Name = "GeFarmer")]
		public async Task<ActionResult<Farmer>> CreateFarmer(string code)
		{
			return new JsonResult(
				new Farmer
				{
					Code = code,
					Name = "Farmer " + code
				}
				);
		}

	}
}
