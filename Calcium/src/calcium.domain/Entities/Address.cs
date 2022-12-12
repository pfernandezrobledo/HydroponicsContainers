using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.Entities
{
	public class Address
	{
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
