using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Service;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }
    
    [HttpGet]
    [Route("Easy/{easy}")]
   
    public string EasyMode(string easy)
    {
        return _guessItService.EasyMode(easy);
    }

    [HttpGet]
    [Route("Medium/{medium}")]
    public string MediumMode(string medium)
    {
        return _guessItService.MediumMode(medium);
    }

    [HttpGet]
    [Route("Hard/{hard}")]
    public string HardMode(string hard)
    {
        return _guessItService.HardMode(hard);
    }

}
