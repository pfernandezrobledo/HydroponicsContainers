using calcium.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcium.domain.Interfaces.Infrastructure
{
	public interface IFarmerDataService
	{
		Task<Farmer> CreateFarmer(Farmer entity);
	}
}
