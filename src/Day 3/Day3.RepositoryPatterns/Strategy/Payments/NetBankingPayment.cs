using System;
using Day3.RepositoryPatterns.Strategy.Interfaces;

namespace Day3.RepositoryPatterns.Strategy.Payments
{
	public class NetBankingPaymentStrategy : IPaymentStrategy
	{
		public void Pay(decimal amount)
		{
			Console.WriteLine($"Paid {amount} using Net Banking Payment.");
		}
	}
}
