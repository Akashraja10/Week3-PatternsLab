using System;

namespace Day1.Exceptions.Exceptions
{
	public class InsufficientFundsException: Exception
	{
		public decimal DeficitAmount { get; }

	    public InsufficientFundsException(string message, decimal deficitAmount) : base(message)
		{ 
			DeficitAmount = deficitAmount;
		}
	}

}