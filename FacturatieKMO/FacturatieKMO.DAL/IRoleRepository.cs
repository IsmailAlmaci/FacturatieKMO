using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL
{
    public interface IRoleRepository
    {
        Role CreateRole(Role role);
        IEnumerable<Role> ReadRoles();
        Role ReadRole(int roleId);
        void DeleteRole(int roleId);
        void UpdateRole(Role role);
    }
}
