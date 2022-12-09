using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.api.Models
{
	public class Address
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id
		{ get; set; }

		public string? StreetLine
		{ get; set; }

		public string? City
		{ get; set; }

		public string? State
		{ get; set; }

		public string? PostalCode
		{ get; set; }

		public string? Country
		{ get; set; }

		public string? Phone
		{ get; set; }

		public string? Fax
		{ get; set; }

		public Address() { }
	}
}
