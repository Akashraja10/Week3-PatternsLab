using Day2.DesignPatterns.Factory.Interfaces;
using Day2.DesignPatterns.Factory.Vehicle;

namespace Day2.DesignPatterns.Factory.Factories
{
	public class TruckFactory: IVehicleFactory
    {
		public IVehicle CreateVehicle()
		{
            Console.WriteLine("Creating a truck through Factory Method...");
            return new Truck();
        }
	}
}
