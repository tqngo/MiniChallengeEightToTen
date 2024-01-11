using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Service.Magic8;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8Controller : ControllerBase
{
    private readonly IMagic8Service _magic8Service;

    public Magic8Controller(IMagic8Service magic8Service)
    {
        _magic8Service = magic8Service;
    }

    [HttpGet]
    [Route("question/{question}")]
    public string Fate(string question)
    {
        return _magic8Service.Fate(question);
    }
}
