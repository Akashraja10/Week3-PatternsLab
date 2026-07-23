using System;
using Day2.DesignPatterns.Factory.Interfaces;

namespace Day2.DesignPatterns.Factory.Vehicle
{
	public class Truck: IVehicle
	{
		public void Start()
		{
			Console.WriteLine("Truck started.");
		}
		public void Stop()
		{
			Console.WriteLine("Truck stopped.");
        }
    }
}
