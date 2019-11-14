using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.BL
{
    public interface IRoleManager
    {
        IEnumerable<Role> GetRoles();
        Role AddRole(int id, string name);
        Role GetRole(int roleId);
        void RemoveRoler(int roleId);
        void ChangeRole(Role role);
    }
}
