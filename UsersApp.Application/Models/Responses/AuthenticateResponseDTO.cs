using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Application.Models.Responses
{
    public class AuthenticateResponseDTO
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? AccessToken { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public AuthenticateResponseDTO()
        {
        }
    }
}
