using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcium.domain.Entities
{
	public abstract class Aggregate : Entity
	{
		public Aggregate(Guid id = default(Guid), string? code = null)
			: base(id, code) { }
	}
}
