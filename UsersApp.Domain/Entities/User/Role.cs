using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Entities.User
{
    public class Role : EntityBase
    {
        #region Properties
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public List<UserRoles> UserRoles { get; set; } = new List<UserRoles>();
        #endregion
        #region Constructors
        public Role()
        {
        }
        #endregion
    }
}
