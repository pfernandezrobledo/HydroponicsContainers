using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calcium.domain.Entities
{
	public class GeoLocation
	{
		public double? Latitude
		{ get; set; }

		public double? Longitude
		{ get; set; }

		public double? LatitudeAccuracy
		{ get; set; }

		public double? LongitudeAccuracy
		{ get; set; }

		public GeoLocation() { }
	}
}
