namespace FacturatieKMO.BL.Domain
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public RoleDTO()
        {
        }

        public RoleDTO(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
    }
}
