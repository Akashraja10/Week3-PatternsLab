using System;

namespace Day2.DesignPatterns.ObserverEvents.Models
{
	public class StockTicker
	{
		public event Action<string, decimal>? PriceChanged;

		public void UpdatePrice(string stockName, decimal price)
		{
            Console.WriteLine($"\nStock Updated: {stockName} -> ₹{price}");

            // Notify all subscribers
            PriceChanged?.Invoke(stockName, price);
		}
    }
}
