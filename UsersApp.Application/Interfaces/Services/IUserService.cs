using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Models.Responses;
using UsersApp.Domain.Entities.User;

namespace UsersApp.Application.Interfaces.Services
{
    public interface IUserService
    {
        List<UsersResponseDTO> GetAll();
        List<UsersResponseDTO> GetAll(Func<UsersResponseDTO, bool> where);
        DefaultResponse Update(UsersResponseDTO model);
        DefaultResponse Delete(UsersResponseDTO model);
        UsersResponseDTO Get(Func<UsersResponseDTO, bool> where);
        UsersResponseDTO GetById(Guid id);
    }
}
