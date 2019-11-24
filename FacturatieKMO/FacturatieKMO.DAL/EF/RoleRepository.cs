using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL.EF
{
    public class RoleRepository : IRoleRepository
    {
        private InvoiceDbContext ctx;

        public RoleRepository()
        {
            ctx = new InvoiceDbContext();
            ctx.Database.Initialize(false);
        }

        public RoleDTO CreateRole(RoleDTO role)
        {
            ctx.Roles.Add(role);
            ctx.SaveChanges();

            return role;
        }

        public void DeleteRole(int roleId)
        {
            RoleDTO role = ctx.Roles.Find(roleId);
            ctx.Roles.Remove(role);
            ctx.SaveChanges();
        }

        public RoleDTO ReadRole(int roleId)
        {
            RoleDTO role = ctx.Roles.Find(roleId);
            return role;
        }

        public IEnumerable<RoleDTO> ReadRoles()
        {
            IEnumerable<RoleDTO> roles = ctx.Roles.AsEnumerable();
            return roles;
        }

        public void UpdateRole(RoleDTO role)
        {
            ctx.Entry(role).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
