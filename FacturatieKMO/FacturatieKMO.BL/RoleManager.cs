using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;

namespace FacturatieKMO.BL
{
    public class RoleManager : IRoleManager
    {
        private IRoleRepository repo;

        public RoleManager()
        {
            repo = new RoleRepository();
        }
        public Role AddRole(int id, string name)
        {
            Role role = new Role(id, name);
            return repo.CreateRole(role);
        }

        public void ChangeRole(Role role)
        {
            repo.UpdateRole(role);
        }

        public Role GetRole(int roleId)
        {
            return repo.ReadRole(roleId);
        }

        public IEnumerable<Role> GetRoles()
        {
            return repo.ReadRoles();
        }

        public void RemoveRoler(int roleId)
        {
            repo.DeleteRole(roleId);
        }
    }
}
