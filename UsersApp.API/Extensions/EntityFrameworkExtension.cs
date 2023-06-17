using Microsoft.EntityFrameworkCore;
using UsersApp.Infra.Data.Contexts;

namespace UsersApp.API.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("UsersApp");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
