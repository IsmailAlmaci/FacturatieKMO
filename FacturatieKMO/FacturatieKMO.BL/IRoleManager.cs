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
        IEnumerable<RoleDTO> GetRoles();
        RoleDTO AddRole(int id, string name, UserDTO user);
        RoleDTO GetRole(int roleId);
        void RemoveRoler(int roleId);
        void ChangeRole(RoleDTO role);
    }
}
