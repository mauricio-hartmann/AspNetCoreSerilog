namespace ANCS.API.Configuration
{
    public static class ApiConfiguration
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app;
        }

        public static IEndpointRouteBuilder UseControllersConfiguration(this IEndpointRouteBuilder app)
        {
            app.MapControllers();

            return app;
        }
    }
}
