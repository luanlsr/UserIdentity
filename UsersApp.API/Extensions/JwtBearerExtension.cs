using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UsersApp.Application.Interfaces.Identities;
using UsersApp.Infra.Identity.Services;
using UsersApp.Infra.Identity.Settings;

namespace UsersApp.API.Extensions
{
    public static class JwtBearerExtension
    {
        public static IServiceCollection AddJwtBearer(this IServiceCollection services, IConfiguration configuration)
        {
            var issuer = configuration.GetSection("IdentitySettings").GetSection("Issuer").Value;
            var audience = configuration.GetSection("IdentitySettings").GetSection("Audience").Value;
            var secretKey = configuration.GetSection("IdentitySettings").GetSection("SecretKey").Value;

            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                    };
                });

            services.Configure<IdentitySettings>(configuration.GetSection("IdentitySettings"));
            services.AddTransient<ITokenCreator, TokenCreator>();

            return services;
        }



    }
}
