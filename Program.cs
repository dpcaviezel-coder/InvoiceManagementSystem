using System;

namespace InvoiceManagementSystem
{
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer("Reinan Tatsuki", "123Reinan@example.com", "123-456-7890");

            InvoiceItem item1 = new InvoiceItem("Laptop", 1, 1200.00);
            InvoiceItem item2 = new InvoiceItem("Mouse", 2, 25.00);
            InvoiceItem item3 = new InvoiceItem("Keyboard", 1, 75.00);

            Invoice invoice1 = new Invoice
            {
                Customer = customer1,
                invoiceItems = new List<InvoiceItem> { item1, item2, item3 }
            };

            InvoiceManager invoiceManager = new InvoiceManager();

            invoiceManager.AddCustomer(customer1);
            invoiceManager.AddInvoiceItem(item1);
            invoiceManager.AddInvoiceItem(item2);
            invoiceManager.AddInvoiceItem(item3);
            invoiceManager.AddInvoice(invoice1);

            invoiceManager.DisplayInvoices();
            invoiceManager.DisplayTotalRevenue();

        }
    }
}
