using ANCS.API.DTOs;

namespace ANCS.API.Services.Interfaces
{
    public interface ILogService
    {
        Task LogMessage(LogInputDTO logInput);
    }
}
