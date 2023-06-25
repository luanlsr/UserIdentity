namespace UsersApp.Domain.Entities.User
{
    public class UserAddress : EntityBase
    {
        #region Properties
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        #endregion
        #region Contructors
        public UserAddress()
        {
        }

        public UserAddress(string? street, string? number, string? complement, string? neighborhood, string? city, string? state, string? country, string? zipCode)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }
        #endregion
    }
}