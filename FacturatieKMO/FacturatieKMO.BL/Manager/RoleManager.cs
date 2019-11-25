using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;

namespace FacturatieKMO.BL
{
    public class RoleManager : IRoleManager
    {
        private IRoleRepository repo;

        public RoleManager()
        {
            repo = new RoleRepository();
        }
        public RoleDTO AddRole(int id, string name, UserDTO user)
        {
            Role role = new Role(id, name, MapDTO.Map<User, UserDTO>(user));
            return MapDTO.Map<RoleDTO, Role>(repo.CreateRole(role));
        }

        public void ChangeRole(RoleDTO role)
        {
            repo.UpdateRole(MapDTO.Map<Role, RoleDTO>(role));
        }

        public RoleDTO GetRole(int roleId)
        {
            return MapDTO.Map<RoleDTO, Role>(repo.ReadRole(roleId));
        }

        public IEnumerable<RoleDTO> GetRoles()
        {
            return MapDTO.MapList<RoleDTO, Role>(repo.ReadRoles());
        }

        public void RemoveRoler(int roleId)
        {
            repo.DeleteRole(roleId);
        }
    }
}
