using ANCS.API.Services.Implementations;
using ANCS.API.Services.Interfaces;

namespace ANCS.API.Configuration
{
    public static class IoCConfiguration
    {
        public static IServiceCollection AddIoCConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ILogService, LogService>();

            return services;
        }
    }
}
