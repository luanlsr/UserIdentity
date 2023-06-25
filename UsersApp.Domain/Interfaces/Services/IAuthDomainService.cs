using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities.User;

namespace UsersApp.Domain.Interfaces.Services
{
    public interface IAuthDomainService : IDisposable
    {
        void CreateAccount(User user);
        User Authenticate(string email, string password);
        User ResetPassword(string email);
    }
}
