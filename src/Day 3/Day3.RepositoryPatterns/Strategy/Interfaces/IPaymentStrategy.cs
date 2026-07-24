using System;

namespace Day3.RepositoryPatterns.Strategy.Interfaces
{
	public interface IPaymentStrategy
	{
		void Pay(decimal amount);
	}
}
