using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities.User;

namespace UsersApp.Domain.Interfaces.Services
{
    public interface IUserDomainService
    {
        List<User> GetAll();
        List<User> GetAll(Func<User, bool> where);
        void Update(User model);
        void Delete(User model);
        User Get(Func<User, bool> where);
        User GetById(Guid id);
    }
}
