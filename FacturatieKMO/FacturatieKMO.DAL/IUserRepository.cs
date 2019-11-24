using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IUserRepository
    {
        UserDTO CreateUser(UserDTO user);
        IEnumerable<UserDTO> ReadUsers();
        UserDTO ReadUser(int userId);
        void DeleteUser(int userId);
        void UpdateUser(UserDTO user);
    }
}
