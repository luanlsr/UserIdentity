namespace UsersApp.Domain.Entities.User
{
    public class UserRoles : EntityBase
    {
        #region Properties
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion

        #region Contructors
        public UserRoles()
        {
        }
        #endregion
    }
}