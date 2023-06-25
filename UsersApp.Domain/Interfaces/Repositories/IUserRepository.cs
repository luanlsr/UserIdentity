using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities.User;

namespace UsersApp.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User, Guid> 
    {
    }
}
