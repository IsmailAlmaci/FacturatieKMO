using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IUserManager
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO AddUsers(int id, string name, string firstName, string email, string address, List<RoleDTO> role, List<InvoiceDTO> invoices);
        UserDTO GetUser(int userId);
        void RemoveUser(int userId);
        void ChangeUser(UserDTO user);
    }
}