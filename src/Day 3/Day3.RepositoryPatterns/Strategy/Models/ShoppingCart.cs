using System;
using Day3.RepositoryPatterns.Strategy.Interfaces;

public class ShoppingCart
{
	private IPaymentStrategy? _paymentStrategy;
	public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
	{
		_paymentStrategy = paymentStrategy;
	}
	public void Checkout(decimal amount)
	{
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Please select a payment method.");
            return;
        }

        Console.WriteLine("\nProcessing payment...");
        _paymentStrategy.Pay(amount);

        Console.WriteLine("Order placed successfully.");
    }
}

