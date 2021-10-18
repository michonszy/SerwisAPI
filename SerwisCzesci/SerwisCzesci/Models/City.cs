using System;

public class City
{
		public int id { get; set; }
		public string Name { get; set; }
		public double TransportCost { get; set; }
		public double CostOfWorkingHours { get; set; }
		public virtual SearchHistory SearchHistory { get; set; }

}
