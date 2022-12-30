using ANCS.API.DTOs;
using ANCS.API.Services.Interfaces;

namespace ANCS.API.Services.Implementations
{
    public class LogService : ILogService
    {
        private readonly ILogger<LogService> _logger;

        public LogService(ILogger<LogService> logger)
        {
            _logger = logger;
        }

        public async Task LogMessage(LogInputDTO logInput)
        {
            await Task.Delay(10);
            _logger.LogInformation(logInput.Message);
        }
    }
}
