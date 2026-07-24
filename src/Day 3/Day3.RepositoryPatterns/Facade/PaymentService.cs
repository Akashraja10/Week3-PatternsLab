namespace Day3.RepositoryPatterns.Facade
{
    public class PaymentService
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} completed.");
        }
    }
}