using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL
{
    public interface IRoleRepository
    {
        RoleDTO CreateRole(RoleDTO role);
        IEnumerable<RoleDTO> ReadRoles();
        RoleDTO ReadRole(int roleId);
        void DeleteRole(int roleId);
        void UpdateRole(RoleDTO role);
    }
}
