using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcium.domain.Entities;

namespace calcium.domain.DataObjects
{
	public class FarmerDTO
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
		public AddressDTO Address
		{ get; set; } = new AddressDTO();

		public string? Email
		{ get; set; }

		public List<HydroPod> Pods
		{ get; set; } = new List<HydroPod>();

		public FarmerDTO() { }
	}
}
