using System;

namespace Day2.DesignPatterns.Observer.Interfaces
{
	public interface IObserver
    {
		void Update(string stockName, decimal price);
    }
}