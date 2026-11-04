namespace InvoiceManagementSystem
{
    public class  InvoiceManager
    {
        List<Invoice> invoices = new();

        List<Customer> customers = new();

        List<InvoiceItem> invoiceItems = new();

        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public void AddCustomer(Customer customer)
        {               
            customers.Add(customer);
        }

        public void AddInvoiceItem(InvoiceItem invoiceItem)
        {
            invoiceItems.Add(invoiceItem);
        }

        public void DisplayInvoices()
        {

            Console.WriteLine("\n===== Invoices: =====");
            foreach (var invoice in invoices)
            {
                Console.WriteLine($"Invoice Products: {string.Join(", ", invoice.invoiceItems.Select(item => item.ItemName))}");
                Console.WriteLine($"Customer: {invoice.Customer.Name}"); 
                Console.WriteLine($"Total Amount: ${invoice.invoiceItems.Sum(item => item.TotalPrice):C}");
                Console.WriteLine("=====================\n");
            }
        }

        public void DisplayTotalRevenue()
        {
            double totalRevenue = invoices.Sum(invoice => invoice.invoiceItems.Sum(item => item.TotalPrice));
            Console.WriteLine($"Total Revenue: ${totalRevenue:C}");
        }
    }
}
