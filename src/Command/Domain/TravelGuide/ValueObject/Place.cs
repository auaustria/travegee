namespace TravelGuide.ValueObject
{
	public class Place //aggregate
	{
		public string Name { get; set; }

		public GeoLocation GeoLocation { get; set; }
	}
}
