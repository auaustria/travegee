using TravelGuide.ValueObject;

namespace TravelGuide.Entity
{
	public class Place //aggregate
	{
		public string Name { get; set; }

		public GeoLocation GeoLocation { get; set; }
	}
}
