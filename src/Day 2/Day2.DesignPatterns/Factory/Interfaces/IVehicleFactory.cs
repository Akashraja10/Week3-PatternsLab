using System;

namespace Day2.DesignPatterns.Factory.Interfaces
{
	public interface IVehicleFactory
	{
		IVehicle CreateVehicle();
	}
}