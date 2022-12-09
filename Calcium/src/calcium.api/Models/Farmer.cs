using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.api.Models
{

	[PrimaryKey(nameof(Id), nameof(Code))]
	public class Farmer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id
		{ get; set; }

		[Key]
		public string? Code
		{ get; set; }

		public string? Name
		{ get; set; }

		public string? Description
		{ get; set; }

		public Guid AddressId { get; set; }

		[ForeignKey("AddressId")]
		public Address Address
		{ get; set; } = new Address();

		public string? Email
		{ get; set; }

		//public List<HydroPod> Pods
		//{ get; set; } = new List<HydroPod>();

		public Farmer() { }
	}
}
