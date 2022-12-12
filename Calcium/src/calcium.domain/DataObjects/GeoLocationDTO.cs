using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.DataObjects
{
	public class GeoLocationDTO
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id
		{ get; set; }

		public double? Latitude
		{ get; set; }

		public double? Longitude
		{ get; set; }

		public double? LatitudeAccuracy
		{ get; set; }

		public double? LongitudeAccuracy
		{ get; set; }

		public GeoLocationDTO() { }
	}
}
