using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities;
using UsersApp.Domain.Interfaces.Repositories;
using UsersApp.Infra.Data.Contexts;

namespace UsersApp.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        private readonly DataContext? _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext) { }
    }
}
