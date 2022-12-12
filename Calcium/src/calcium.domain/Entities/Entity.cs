using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcium.domain.Entities
{
	public abstract class Entity
	{
		public Guid Id
		{ get; private set; }

		public string? Code
		{ get; private set; }

		public Entity(Guid id = default(Guid), string? code = null)
		{
			this.Id = id;
			this.Code = code;
		}


		public void GenerateIdentifiers()
		{
			this.Id = Guid.NewGuid();
			this.Code = Guid.NewGuid().ToString("N")[..7];
		}
	}
}
