using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Entities;
using UsersApp.Domain.Exceptions.Users;
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

        public User Authenticate(string email, string password)
        {
            var user = _unitOfWork.UserRepository.Get(u => u.Email.Equals(email) && u.Password.Equals(password));
            if (user == null)
            {
                throw new DeniedAccessException();
            }
            return user;
        }

        public void CreateAccount(User user)
        {
            var registredUser = _unitOfWork.UserRepository.Get(e => e.Email.Equals(user.Email));
            if (registredUser != null)
            {
                throw new EmailAllReadyExistsException();
            }

            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.SaveChanges();
        }

        public User ResetPassword(string email)
        {
            var user = _unitOfWork?.UserRepository.Get(u => u.Email.Equals(email));
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            //TODO
            return user;
        }

        public void Dispose()
        {
            _unitOfWork.UserRepository.Dispose();
        }
    }
}
