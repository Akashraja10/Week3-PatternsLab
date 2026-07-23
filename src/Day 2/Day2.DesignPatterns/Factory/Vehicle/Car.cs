using System;
using Day2.DesignPatterns.Factory.Interfaces;

namespace Day2.DesignPatterns.Factory.Vehicle
{
	public class Car: IVehicle
	{
		public void Start()
		{
			Console.WriteLine("Car started.");
		}
		public void Stop()
		{
			Console.WriteLine("Car stopped.");
		}
    }
}
