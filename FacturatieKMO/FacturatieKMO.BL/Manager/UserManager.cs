using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class UserManager : IUserManager
    {
        private IUserRepository repo;

        public UserManager()
        {
            repo = new UserRepository();
        }

        public UserDTO AddUsers(int id, string name, string firstName, string email, string address, List<RoleDTO> role, List<InvoiceDTO> invoices)
        {
            ICollection<Role> roles = new List<Role>();
            ICollection<Invoice> invoiceList = new List<Invoice>();

            foreach (RoleDTO item in role)
            {
                roles.Add(MapDTO.Map<Role, RoleDTO>(item));
            }

            foreach (InvoiceDTO item in invoices)
            {
                invoiceList.Add(MapDTO.Map<Invoice, InvoiceDTO>(item));
            }

            User user = new User(id, name, firstName, email, address, roles, invoiceList);
            return MapDTO.Map<UserDTO, User>(repo.CreateUser(user));
        }

        public void ChangeUser(UserDTO user)
        {
            repo.UpdateUser(MapDTO.Map<User, UserDTO>(user));
        }

        public UserDTO GetUser(int userId)
        {
            return MapDTO.Map<UserDTO, User>(repo.ReadUser(userId));
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return MapDTO.MapList<UserDTO, User>(repo.ReadUsers());
        }

        public void RemoveUser(int userId)
        {
            repo.DeleteUser(userId);
        }
    }
}
