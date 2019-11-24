using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.BL.Domain
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public RoleDTO(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }

        public RoleDTO()
        {
        }
    }
}
