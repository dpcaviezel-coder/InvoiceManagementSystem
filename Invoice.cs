namespace InvoiceManagementSystem
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public List<InvoiceItem> invoiceItems { get; set; }
        public void PrintInvoice()
        {
            Console.WriteLine($"Invoice for {Customer.Name}");
            Console.WriteLine("Items:");
            foreach (var item in invoiceItems)
            {
                Console.WriteLine($"{item.ItemName} - {item.Quantity} x {item.UnitPrice:C}");
            }
            Console.WriteLine($"Total: {invoiceItems.Sum(item => item.TotalPrice):C}");
        }
    }
}
