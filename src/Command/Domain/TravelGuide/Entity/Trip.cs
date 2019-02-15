using Common;
using System;

namespace TravelGuide.Entity
{
	public class Trip//aggregate
	{
		public Trip(Guid tripId, Guid ownerId, string name)
		{
			
		}

		public void AddNotes(string note)
		{

		}

		public void SetOverAllCost(double price, Money amount)
		{

		}

		public void SetOverAllCostToAutoCompute(bool autoComputeCost)
		{

		}

		public void AddStop(string name, string placeId, string notes)
		{
			var sequence = 0; //todo
			var stop = new Stop(name, placeId, notes, sequence);
		}
		
		public void SetStopNote(Guid stopId, string notes)
		{

		}
	}
}
