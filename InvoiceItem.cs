namespace InvoiceManagementSystem
{
    public class  InvoiceItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double TotalPrice
        {
            get { return Quantity * UnitPrice; }
        }

        public InvoiceItem(string itemName, int quantity, double unitPrice)
        {
            ItemName = itemName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
