using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Helpers;
using UsersApp.Application.Models.Requests;
using UsersApp.Application.Models.Responses;
using UsersApp.Domain.Entities.User;

namespace UsersApp.Application.Profiles
{
    public class DTOToDomainModelProfile : Profile
    {
        /// <summary>
        /// Mapeamento de DTOs para Modelos de domínio
        /// </summary>
        public DTOToDomainModelProfile()
        {
            CreateMap<CreateAccountRequestDTO, User>()
                .AfterMap((dto, model) =>
                {
                    model.Id = Guid.NewGuid();
                    model.CreatedAt = DateTime.Now;
                    model.Password = SHA1Helper.Encrypt(dto.Password);
                });

            CreateMap<AuthenticateRequestDTO, User>()
                .AfterMap((dto, model) =>
                {
                    model.Password = SHA1Helper.Encrypt(dto.Password);
                });

            CreateMap<UsersResponseDTO, User>();
        }
    }



}
