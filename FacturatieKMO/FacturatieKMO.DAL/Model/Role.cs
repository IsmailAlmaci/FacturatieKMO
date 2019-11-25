using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public User User { get; set; }

        public Role()
        {
        }

        public Role(int roleId, string roleName, User user)
        {
            RoleId = roleId;
            RoleName = roleName;
            User = user;
        }
    }
}
