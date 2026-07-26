using System;
using Day5.OOPConcepts.Task113a.Interfaces;

namespace Day5.OOPConcepts.Task113a.Models
{
	public class Car : IVehicle
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
