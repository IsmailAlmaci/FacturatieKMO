namespace FacturatieKMO.BL.Domain
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public UserDTO User { get; set; }

        public RoleDTO()
        {
        }

        public RoleDTO(int roleId, string roleName, UserDTO user)
        {
            RoleId = roleId;
            RoleName = roleName;
            User = user;
        }
    }
}
