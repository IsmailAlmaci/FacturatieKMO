namespace FacturatieKMO.BL.Domain
{
    public class Customer
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer(string name, string firstName, string email, string address)
        {
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
        }
    }
}
