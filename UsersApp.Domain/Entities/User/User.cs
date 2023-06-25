using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Entities.User
{
    public class User : EntityBase
    {
        #region Properties
        public string? Name { get; set; }
        //public string? LastName { get; set; }
        //public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        //public bool? IsVerified => Verified.HasValue || PasswordReset.HasValue;
        //public int? AccessFailedCount { get; set; }
        //public string? VerificationToken { get; set; }
        //public string? RefreshToken { get; set; }
        //public DateTime? Verified { get; set; }
        //public DateTime? ResetTokenExpires { get; set; }
        //public DateTime? PasswordReset { get; set; }
        //public List<UserPhone>? Phones { get; set; } = new List<UserPhone>();
        //public List<UserRoles>? Roles { get; set; } = new List<UserRoles>();
        //public List<UserAddress>? Addresses { get; set; } = new List<UserAddress>();
        //public List<RefreshToken>? RefreshTokens { get; set; } = new List<RefreshToken>();
        //#endregion
        //#region Constructors
        //public User() { }
        //public User(string firstName, string lastName, string userName, List<UserRoles> roles, string email, string passwordHash)
        //{
        //    Username = userName;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Roles = roles;
        //    Email = email;
        //    AccessFailedCount = 0;
        //    PasswordHash = passwordHash;
        //}
        //public void Update(string firstName, string lastName, List<UserRoles> roles, string email)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Roles = roles;
        //    if (Email != email)
        //    {
        //        Email = email;
        //    }
        //}

        //public void UpdatePassword(string password)
        //{
        //    PasswordHash = password;
        //}

        //public bool HasToken(string token)
        //{
        //    return RefreshTokens?.Find(x => x.Token == token) != null;
        //}
        #endregion
    }
}
