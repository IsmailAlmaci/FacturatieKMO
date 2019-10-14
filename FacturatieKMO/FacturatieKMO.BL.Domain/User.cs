namespace FacturatieKMO.BL.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public User(int userId, string name, string firstName, string email, string address, Role role)
        {
            UserId = userId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Role = role;
        }
    }
}