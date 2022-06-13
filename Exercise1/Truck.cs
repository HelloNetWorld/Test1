using System;

namespace Exercise1
{
	public class Truck : Car
	{
		public Truck(string type, double fuelConsumptionAvg, double speed,
			double fuelTankCapacity, double remainingFuel, double maxCargo)
			: base(type, fuelConsumptionAvg, speed, fuelTankCapacity, remainingFuel)
		{
			MaxCargo = maxCargo;
		}

		public double MaxCargo { get; private set; }

		/// <summary>
		/// Returns distance that your car can travel on a remaining fuel depending on cargo
		/// </summary>
		/// <param name="cargo">Kg</param>
		/// <returns></returns>
		public double RemainingFuelRange(double cargo)
		{
			if (cargo > MaxCargo) throw new ArgumentOutOfRangeException(
				$"Parameter {nameof(cargo)} must be equal or less then {nameof(MaxCargo)}");

			return base.RemainingFuelRangeBase(0, cargo);
		}
	}
}
