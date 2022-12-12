using calcium.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcium.domain.Interfaces.Application
{
	public interface IFarmerAppService
	{
		Task<Farmer> CreateFarmer(Farmer entity);
	}
}
