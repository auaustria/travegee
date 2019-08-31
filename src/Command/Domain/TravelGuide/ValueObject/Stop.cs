namespace TravelGuide.ValueObject
{
	public class Stop
	{
		public Stop(string name, string placeId, string notes, int sequence)
		{
				
		}

		public string Name { get; set; }

		//PlaceId will come from google maps
		public string PlaceId { get; set; }

		public string Notes { get; set; }

		public int Sequence { get; set; }
	}
}
