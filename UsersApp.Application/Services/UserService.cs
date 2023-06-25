using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Interfaces.Identities;
using UsersApp.Application.Interfaces.Produces;
using UsersApp.Application.Interfaces.Services;
using UsersApp.Application.Models.Responses;
using UsersApp.Domain.Entities.User;
using UsersApp.Domain.Interfaces.Services;

namespace UsersApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly ITokenCreator _tokenCreator;
        private readonly IUserDomainService _userDomainService;
        private readonly IUserMessageProducer _userMessage;

        public UserService(IMapper mapper, ITokenCreator tokenCreator, IUserDomainService userDomainService, IUserMessageProducer userMessage)
        {
            _mapper = mapper;
            _tokenCreator = tokenCreator;
            _userDomainService = userDomainService;
            _userMessage = userMessage;
        }

        public List<UsersResponseDTO> GetAll()
        {
            return _mapper.Map<List<UsersResponseDTO>>(_userDomainService.GetAll());
        }

        public List<UsersResponseDTO> GetAll(Func<UsersResponseDTO, bool> where)
        {
            throw new NotImplementedException();
        }

        public DefaultResponse Delete(UsersResponseDTO model)
        {
            throw new NotImplementedException();
        }

        public UsersResponseDTO Get(Func<UsersResponseDTO, bool> where)
        {
            throw new NotImplementedException();
        }



        public UsersResponseDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public DefaultResponse Update(UsersResponseDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
