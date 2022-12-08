namespace calcium.api.Models
{
	public class Farmer
	{
		public string Name
		{ get; set; }

		public string Description
		{ get; set; }

		public Address Address
		{ get; set; }

		public string Email
		{ get; set; }

		public List<HydroPod> Pods
		{ get; set; }

		public Farmer() { }
	}
}
