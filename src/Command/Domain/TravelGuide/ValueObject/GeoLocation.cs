namespace TravelGuide.ValueObject
{
	public class GeoLocation //value object
	{
		public GeoLocation(double longitude, double latitude)
		{
			Longitude = longitude;
			Latitude = latitude;
		}

		public double Longitude { get; private set; }
		public double Latitude { get; private set; }
	}
}
