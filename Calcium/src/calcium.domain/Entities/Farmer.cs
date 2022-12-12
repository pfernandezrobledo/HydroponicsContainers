using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.Entities
{

	public class Farmer : Aggregate
	{
		public string? Name
		{ get; set; }

		public string? Description
		{ get; set; }

		public Address Address
		{ get; set; } = new Address();

		public string? Email
		{ get; set; }

		public List<HydroPod> Pods
		{ get; set; } = new List<HydroPod>();

		public Farmer(Guid id = default(Guid), string? code = null) :
			base(id, code)
		{ }
	}
}
