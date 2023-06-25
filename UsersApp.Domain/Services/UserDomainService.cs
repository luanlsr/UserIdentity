using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities.User;
using UsersApp.Domain.Exceptions.Auth;
using UsersApp.Domain.Exceptions.User;
using UsersApp.Domain.Interfaces.Repositories;
using UsersApp.Domain.Interfaces.Services;

namespace UsersApp.Domain.Services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public UserDomainService(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<User> GetAll()
        {
            var users = _unitOfWork?.UserRepository.GetAll();
            if (users == null)
            {
                throw new NoRegistredUserException();
            }
            return users;
        }

        public List<User> GetAll(Func<User, bool> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(Func<User, bool> where)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
