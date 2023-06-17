using FluentValidation;
using UsersApp.API.Validators;
using UsersApp.Application.Interfaces.Identities;
using UsersApp.Application.Interfaces.Produces;
using UsersApp.Application.Interfaces.Services;
using UsersApp.Application.Models.Requests;
using UsersApp.Application.Models.Validators;
using UsersApp.Application.Services;
using UsersApp.Domain.Interfaces.Repositories;
using UsersApp.Domain.Interfaces.Services;
using UsersApp.Domain.Services;
using UsersApp.Infra.Data.Repositories;
using UsersApp.Infra.Identity.Services;
using UsersApp.Infra.Messages.Producers;
using UsersApp.Infra.Messages.Settings;

namespace UsersApp.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MessageSettings>(configuration.GetSection("MessageSettings"));
            services.AddTransient<IUserAppService, UserAppService>();
            services.AddTransient<IUserDomainService, UserDomainService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserMessageProducer, UserMessageProducer>();
            services.AddTransient<ITokenCreator, TokenCreator>();

            return services;
        }
    }
}
