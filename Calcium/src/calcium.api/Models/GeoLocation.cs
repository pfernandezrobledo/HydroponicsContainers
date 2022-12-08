namespace calcium.api.Models
{
	public class GeoLocation
	{
		public double Latitude
		{ get; set; }

		public double Longitude
		{ get; set; }

		public double LatitudeAccuracy
		{ get; set; }

		public double LongitudeAccuracy
		{ get; set; }

		public GeoLocation() { }
	}
}
