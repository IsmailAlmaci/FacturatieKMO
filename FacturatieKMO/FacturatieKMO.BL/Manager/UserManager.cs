using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
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

        public UserDTO AddUsers(int id, string name, string firstName, string email, string address, List<RoleDTO> role)
        {
            UserDTO user = new UserDTO(id, name, firstName, email, address, role);
            return repo.CreateUser(user);
        }

        public void ChangeUser(UserDTO user)
        {
            repo.UpdateUser(user);
        }

        public UserDTO GetUser(int userId)
        {
            return repo.ReadUser(userId);
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return repo.ReadUsers();
        }

        public void RemoveUser(int userId)
        {
            repo.DeleteUser(userId);
        }
    }
}
