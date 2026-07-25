namespace Day4.ReflectionTPL.Task111
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public string? CustomerName { get; set; }

        public decimal Amount { get; set; }

        public Invoice()
        {
        }

        public Invoice(int invoiceId, string customerName)
        {
            InvoiceId = invoiceId;
            CustomerName = customerName;
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Invoice : {InvoiceId}");

            Console.WriteLine($"Customer : {CustomerName}");

            Console.WriteLine($"Amount : {Amount}");
        }
    }
}