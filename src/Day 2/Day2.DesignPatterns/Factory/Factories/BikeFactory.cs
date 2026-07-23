using Day2.DesignPatterns.Factory.Interfaces;
using Day2.DesignPatterns.Factory.Vehicle;

namespace Day2.DesignPatterns.Factory.Factories
{
	public class BikeFactory : IVehicleFactory
    {
		public IVehicle CreateVehicle()
		{
            Console.WriteLine("Creating a bike through Factory Method...");
            return new Bike();
        }
	}
}
