using System;

namespace Exercise1
{
	public class Car
	{
		public Car(string type, double fuelConsumptionAvg, double speed,
			double fuelTankCapacity, double remainingFuel)
		{
			Type = type;
			FuelConsumptionAvg = fuelConsumptionAvg;
			Speed = speed;
			FuelTankCapacity = fuelTankCapacity;
			RemainingFuel = remainingFuel;
		}

		public string Type { get; set; }
		public double FuelConsumptionAvg { get; set; }
		public double Speed { get; set; }
		public double FuelTankCapacity { get; set; }
		public double RemainingFuel { get; set; }

		/// <summary>
		/// Returns distance that your car can travel on a full tank of fuel
		/// </summary>
		public double FullFuelRange()
			=> FuelConsumptionAvg * FuelTankCapacity;

		/// <summary>
		/// Returns distance that your car can travel on a remaining fuel
		/// </summary>
		public double RemainingFuelRange()
			=> FuelConsumptionAvg * RemainingFuel;

		/// <summary>
		/// Returns distance that your car can travel on a remaining fuel depending on passengers and cargo
		/// </summary>
		/// <param name="passengers">quantity</param>
		/// <param name="cargo">Kg</param>
		/// <returns></returns>
		private protected double RemainingFuelRangeBase(int passengers, double cargo)
		{
			if (passengers < 0) throw new ArgumentOutOfRangeException($"Parameter {nameof(passengers)} must be positive");
			if (cargo < 0.0) throw new ArgumentOutOfRangeException($"Parameter {nameof(cargo)} must be positive");

			var remainingFuelRange = this.RemainingFuelRange();
			return remainingFuelRange - passengers * remainingFuelRange * 0.06 - (cargo / 200) * 0.04 * remainingFuelRange;
		}

		/// <summary>
		/// Returns timespan, that it takes for a car to cover a distance at a certain speed
		/// </summary>
		/// <param name="distance">Km</param>
		/// <param name="speed">Km/h</param>
		/// <returns></returns>
		public TimeSpan DistancePass(double distance, double speed) => TimeSpan.FromHours(distance / speed * 60);
	}
}
