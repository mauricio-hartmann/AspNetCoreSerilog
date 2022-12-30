using ANCS.API.Configuration;
using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Host.AddLogConfiguration(builder.Configuration);

    builder.Services
        .AddApiConfiguration()
        .AddSwagger()
        .AddIoCConfiguration();

    var app = builder.Build();

    app.UseMiddlewaresConfiguration()
        .UseSwagger(app.Environment)
        .UseApiConfiguration();

    app.UseControllersConfiguration();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.Information("Server Shutting down...");
    Log.CloseAndFlush();
}