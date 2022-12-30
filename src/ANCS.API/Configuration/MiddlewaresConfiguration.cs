using ANCS.API.Middlewares;

namespace ANCS.API.Configuration
{
    public static class MiddlewaresConfiguration
    {
        public static WebApplication UseMiddlewaresConfiguration(this WebApplication webApplication) {
            webApplication.UseMiddleware<ErrorHandlingMiddleware>();
            webApplication.UseMiddleware<RequestSerilLogMiddleware>();

            return webApplication;
        }
    }
}
