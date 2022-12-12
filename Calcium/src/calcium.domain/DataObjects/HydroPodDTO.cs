
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.DataObjects
{
	public class HydroPodDTO
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
		public AddressDTO? Address
		{ get; set; } = new AddressDTO();

		public Guid GeoLocationId { get; set; }

		[ForeignKey("GeoLocationId")]
		public GeoLocationDTO? GeoLocation
		{ get; set; } = new GeoLocationDTO();

		public ContainerGrowType? ContainerGrow
		{ get; set; }

		public InsulationMaterialType insulationMaterial
		{ get; set; }

		public InsulationFactorType InsulationFactor
		{ get; set; }



		public HydroPodDTO() { }


	}
}