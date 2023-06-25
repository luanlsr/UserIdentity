using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UsersApp.Domain.Entities.User
{
    public class RefreshToken
    {
        [Key]
        [JsonIgnore]
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Revoked { get; set; }
        public string CreatedByIp { get; set; }
        public string? RevokedByIp { get; set; }
        public string? ReplacedByToken { get; set; }
        public string? ReasonRevoked { get; set; }
        public UserAgentInfo UserAgent { get; set; }
        public bool IsExpired
        {
            get { return DateTime.UtcNow >= Expires; }
            private set { }
        }
        public bool IsRevoked
        {
            get { return Revoked != null; }
            private set { }
        }
        public bool IsActive
        {
            get { return Revoked == null && !IsExpired; }
            private set { }
        }


        public RefreshToken() { }

    }
}