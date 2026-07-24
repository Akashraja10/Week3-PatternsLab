namespace Day3.RepositoryPatterns.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventory;
        private readonly PaymentService _payment;
        private readonly ShippingService _shipping;

        public OrderFacade()
        {
            _inventory = new InventoryService();
            _payment = new PaymentService();
            _shipping = new ShippingService();
        }

        public void PlaceOrder(decimal amount)
        {
            Console.WriteLine("\nPlacing Order...\n");

            _inventory.CheckStock();
            _payment.MakePayment(amount);
            _shipping.ShipOrder();

            Console.WriteLine("\nOrder placed successfully.");
        }
    }
}