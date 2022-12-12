
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.Entities
{
	public class HydroPod : Entity
	{
		public string? Name
		{ get; set; }

		public string? Description
		{ get; set; }

		public Address? Address
		{ get; set; } = new Address();

		public GeoLocation? GeoLocation
		{ get; set; } = new GeoLocation();

		public ContainerGrowType? ContainerGrow
		{ get; set; }

		public InsulationMaterialType insulationMaterial
		{ get; set; }

		public InsulationFactorType InsulationFactor
		{ get; set; }



		public HydroPod(Guid id = default(Guid), string? code = null) :
			base(id, code)
		{ }


	}
}



/*
Code.  (Required) This is a short 10 character alphanumeric code that identifies the pod. 

Container Type.  (Required) This is the type of container, could be 40ftVF, 20ftVF, 40ftRF, 20ftRF.  These refer to the size of the container and the internal setup for hydroponics growing: vertical or row farming 

Address.  (Required if location is not present) The address where this pod is located.  Many pods could share a single address 

Location.    (Required if address is not present) The latitude and longitude where the pod is located.  This is for the case when the address cannot be provided.  Think 'middle of nowhere' location. 

Insulation Type.  The type of insulation used in the pod, could be: None, Fiberglass, Cellulose, Foam, Mineral 

Insulation Factor.  The insulation factor that is provided from the insulation applies to the pod, could be: R0, R5,, R10,R20, R40.  
*/