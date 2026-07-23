using System;
using Day2.DesignPatterns.Observer.Interfaces;

namespace Day2.DesignPatterns.Observer.Models
{
	public class Investor : IObserver
	{
		private string Name { get; }
		public Investor(string name)
		{
			Name = name;
		}
		public void Update(string stockName, decimal price)
		{
			Console.WriteLine($"Investor {Name} notified: {stockName} price changed to {price}");
		}
	}
}
