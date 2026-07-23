using System;
using Day2.DesignPatterns.Factory.Interfaces;

namespace Day2.DesignPatterns.Factory.Vehicle
{
	public class Bike: IVehicle
	{
		public void Start()
		{
			Console.WriteLine("Bike started.");
		}
		public void Stop()
		{
			Console.WriteLine("Bike stopped.");
		}
    }
}
