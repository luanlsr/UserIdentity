using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Models.Requests;
using UsersApp.Application.Models.Responses;

namespace UsersApp.Application.Interfaces.Services
{
    public interface IAuthService : IDisposable
    {
        AuthenticateResponseDTO Authenticate(AuthenticateRequestDTO dto);
        CreateAccountResponseDTO CreateAccount(CreateAccountRequestDTO dto);
        ResetPasswordResponseDTO ResetPassword(ResetPasswordRequestDTO dto);
    }
}
