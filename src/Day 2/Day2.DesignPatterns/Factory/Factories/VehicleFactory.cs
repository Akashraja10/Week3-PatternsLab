using System;
using Day2.DesignPatterns.Factory.Interfaces;
using Day2.DesignPatterns.Factory.Vehicle;

namespace Day2.DesignPatterns.Factory.Factories
{
	public class VehicleFactory
	{
		public static IVehicle CreateVehicle(string vehicleType)
		{
			switch (vehicleType.ToLower())
			{
				case "car":
					Console.WriteLine("Creating a car through Factory Pattern...");
                    return new Car();
				case "bike":
					Console.WriteLine("Creating a bike through Factory Pattern...");
                    return new Bike();
				case "truck":
					Console.WriteLine("Creating a truck through Factory Pattern...");
                    return new Truck();
				default:
					throw new ArgumentException("Invalid vehicle type");
            }
        }
	}
}
