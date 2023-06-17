using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Models.Producers;
using UsersApp.Application.Models.Responses;
using UsersApp.Domain.Entities;

namespace UsersApp.Application.Profiles
{
    public class DomainModelToDTOProfile : Profile
    {
        /// <summary>
        /// Mapeamento de DTOs para Modelos de domínio
        /// </summary>
        public DomainModelToDTOProfile()
        {
            CreateMap<User, CreateAccountResponseDTO>();
            CreateMap<User, AuthenticateResponseDTO>();
            CreateMap<User, ResetPasswordResponseDTO>();

            CreateMap<User, UserMessageDTO>()
                .AfterMap((model, dto) =>
                {
                    dto.CreatedAt = DateTime.UtcNow;
                });
        }
    }
}
