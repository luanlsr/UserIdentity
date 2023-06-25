namespace UsersApp.Domain.Entities.User
{
    public class UserPhone : EntityBase
    {
        #region Properties
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string? PhoneCountry { get; set; }
        public string? PhoneDDD { get; set; }
        public string? PhoneNumber { get; set; }
        #endregion
        #region Constructors

        public UserPhone()
        {
        }

        public UserPhone(Guid userId, User user, string? phoneCountry, string? phoneDDD, string? phoneNumber)
        {
            UserId = userId;
            PhoneCountry = phoneCountry;
            PhoneDDD = phoneDDD;
            PhoneNumber = phoneNumber;
        }
        #endregion
    }
}