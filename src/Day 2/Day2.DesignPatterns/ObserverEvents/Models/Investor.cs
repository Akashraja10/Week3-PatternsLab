using System;

namespace Day2.DesignPatterns.ObserverEvents.Models
{
	public class Investor
	{
		private string Name;
		public Investor(string name)
		{
			Name = name;
		}
		public void ReceiveNotification(string stockName, decimal price)
		{
			Console.WriteLine($"{Name} received update: {stockName} = ₹{price}");
		}
	}
}
