using System;
using Day2.DesignPatterns.Observer.Interfaces;

namespace Day2.DesignPatterns.Observer.Models
{
	public class StockTicker
	{
		private readonly List<IObserver> _observers = new();

		public void Subscribe(IObserver observer)
		{
			if (!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}
		}
		public void UnSubscribe(IObserver observer)
		{
			if (_observers.Contains(observer))
			{
				_observers.Remove(observer);
			}
		}
		public void UpdatePrice(string stock, decimal price)
		{
            Console.WriteLine($"\nStock Updated : {stock} -> ₹{price}");
			Notify(stock, price);
        }

        public void Notify(string stock, decimal price)
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(stock, price);
			}
		}
	}
}
