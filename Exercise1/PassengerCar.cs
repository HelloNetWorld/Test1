using System;

namespace Exercise1
{
	public class PassengerCar : Car
	{
		public PassengerCar(string type, double fuelConsumptionAvg, double speed,
			double fuelTankCapacity, double remainingFuel, int maxPassengers) 
			: base(type, fuelConsumptionAvg, speed, fuelTankCapacity, remainingFuel)
		{
			MaxPassengers = maxPassengers;
		}

		public int MaxPassengers { get; private set; }

		/// <summary>
		/// Returns distance that your car can travel on a remaining fuel depending on cargo
		/// </summary>
		/// <param name="passengers"></param>
		/// <returns></returns>
		public double RemainingFuelRange(int passengers)
		{
			if (passengers > MaxPassengers) throw new ArgumentOutOfRangeException(
				$"Parameter {nameof(passengers)} must be equal or less then {nameof(MaxPassengers)}");

			return base.RemainingFuelRangeBase(passengers, 0);
		}
	}
}
