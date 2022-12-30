using ANCS.API.DTOs;
using ANCS.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ANCS.API.Controllers;

[ApiController]
[Route("log")]
public class LogController : ControllerBase 
{
    private readonly ILogService _logService;

    public LogController(ILogService logService)
    {
        _logService = logService;
    }


    [HttpPost]
    public async Task<IActionResult> LogMessage([FromBody] LogInputDTO logInput)
    {
        await _logService.LogMessage(logInput);

        return Ok();
    }
}
