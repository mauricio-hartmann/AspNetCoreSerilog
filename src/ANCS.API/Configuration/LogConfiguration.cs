using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Sinks.ElmahIo;

namespace ANCS.API.Configuration
{
    public static class LogConfiguration
    {
        public static ConfigureHostBuilder AddLogConfiguration(this ConfigureHostBuilder host, IConfiguration configuration)
        {
            var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "dev";

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .Enrich.WithExceptionDetails()
                .Enrich.WithCorrelationId()
                .Enrich.WithProperty("ApplicationName", $"AspNetCoreSerilog - {environment}")
                .WriteTo.Async(wt => wt.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}"))
                .WriteTo.ElmahIo(new ElmahIoSinkOptions(configuration.GetValue<string>("ElmahIO:Key"), new Guid(configuration.GetValue<string>("ElmahIO:Id"))))
                .CreateLogger();

            host.UseSerilog();

            return host;
        }
    }
}
