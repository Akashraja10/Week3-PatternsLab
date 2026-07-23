using Day2.DesignPatterns.Factory.Interfaces;
using Day2.DesignPatterns.Factory.Vehicle;

namespace Day2.DesignPatterns.Factory.Factories
{
	public class CarFactory : IVehicleFactory
    {
		public IVehicle CreateVehicle()
		{
            Console.WriteLine("Creating a car through Factory Method...");
            return new Car();
        }
	}
}
