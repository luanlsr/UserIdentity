using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Interfaces.Identities;
using UsersApp.Application.Interfaces.Produces;
using UsersApp.Application.Interfaces.Services;
using UsersApp.Application.Models.Producers;
using UsersApp.Application.Models.Requests;
using UsersApp.Application.Models.Responses;
using UsersApp.Domain.Entities.User;
using UsersApp.Domain.Interfaces.Services;
using static UsersApp.Application.Services.AuthService;

namespace UsersApp.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly ITokenCreator _tokenCreator;
        private readonly IAuthDomainService _userDomainService;
        private readonly IUserMessageProducer _userMessage;

        public AuthService(IMapper mapper, ITokenCreator tokenCreator, IAuthDomainService userDomainService, IUserMessageProducer userMessage)
        {
            _mapper = mapper;
            _tokenCreator = tokenCreator;
            _userDomainService = userDomainService;
            _userMessage = userMessage;
        }

        public AuthenticateResponseDTO Authenticate(AuthenticateRequestDTO dto)
        {
            var passwordSha1 = _mapper.Map<User>(dto).Password;
            var user = _userDomainService.Authenticate(dto.Email, passwordSha1);
            var response = _mapper.Map<AuthenticateResponseDTO>(user);

            response.AccessToken = _tokenCreator.Create(dto.Email, "USER_ROLE");
            response.ExpirationDate = DateTime.UtcNow.AddHours(1);
            return response;
        }

        public CreateAccountResponseDTO CreateAccount(CreateAccountRequestDTO dto)
        {
            var user = _mapper?.Map<User>(dto);
            _userDomainService.CreateAccount(user);

            #region Gerar notificação para envio de mensagem de boas vindas
            var userMessageDTO = _mapper.Map<UserMessageDTO>(user);
            userMessageDTO.Type = MessageType.Create_account;

            _userMessage.Send(userMessageDTO);
            #endregion

            return _mapper.Map<CreateAccountResponseDTO>(user);
        }


        public ResetPasswordResponseDTO ResetPassword(ResetPasswordRequestDTO dto)
        {
            var user = _userDomainService.ResetPassword(dto.Email);
            return _mapper.Map<ResetPasswordResponseDTO>(user);
        }

        public void Dispose()
        {
            _userDomainService.Dispose();
        }



    }
}
