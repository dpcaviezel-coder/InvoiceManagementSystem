namespace InvoiceManagementSystem
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public double AccountBalance { get; set; }
        public Customer(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            AccountBalance = 0.0;
        }

        public void UpdateAccountBalance(double amount)
        {
            AccountBalance += amount;
        }
    }
}
