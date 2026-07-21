using Day1.Exceptions.Exceptions;

namespace Day1.Exceptions.Models
{
	public class BankAccount
	{
		public string AccountHolder {  get; set; }
		public decimal Balance { get; set; }

		public BankAccount(string accountHolder, decimal balance)
		{
			AccountHolder = accountHolder;
			Balance = balance;
		}

		public void WithdrawAmount(decimal amount)
		{
			if (amount > Balance)
			{
				decimal deficit = amount - Balance;

				throw new InsufficientFundsException(
					$"Withdrawal failed. Available balance is only	{Balance}.", deficit);
            }
            Balance = Balance - amount;

            Console.WriteLine($"Withdrawal successful.");
            Console.WriteLine($"Remaining Balance : {Balance}");
        }
	}
}
