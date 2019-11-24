﻿namespace FacturatieKMO.BL.Domain
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public CustomerDTO()
        {

        }
        public CustomerDTO(int userId, string name, string firstName, string email, string address)
        {
            CustomerId = userId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
        }
    }
}
