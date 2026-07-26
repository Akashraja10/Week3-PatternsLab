namespace Day5.OOPConcepts.Task113b.Services
{
    public class OrderProcessor
    {
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }

        public OrderProcessor(string customerName, decimal orderAmount)
        {
            CustomerName = customerName;
            OrderAmount = orderAmount;
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"{CustomerName} placed an order for ${OrderAmount}.");
        }

        public decimal CalculateDiscount()
        {
            if (OrderAmount >= 1000)
                return OrderAmount * 0.10m;

            return 0;
        }

        public void GenerateInvoice()
        {
            decimal discount = CalculateDiscount();

            Console.WriteLine("\n===== Invoice =====");
            Console.WriteLine($"Customer : {CustomerName}");
            Console.WriteLine($"Order Amount : ${OrderAmount}");
            Console.WriteLine($"Discount : ${discount}");
            Console.WriteLine($"Final Amount : ${OrderAmount - discount}");
        }
    }
}