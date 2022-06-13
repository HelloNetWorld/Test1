using System;

namespace Exercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			var truck = new Truck("TowTruck", 6.3, 90, 150, 88, 2000);
			Console.WriteLine(truck.RemainingFuelRange(680));
		}
	}
}
