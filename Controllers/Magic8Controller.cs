using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8Controller : ControllerBase
{

    public List<string> response = new();
    public Random randResponse = new();
    public string answer = "";

    [HttpGet]
    [Route("question/{question}")]

    public string Fate(string question)
    {
        response.Add("Outlook good");
        response.Add("Most Likely");
        response.Add("Yes definitely");
        response.Add("Ask again later");
        response.Add("Better not tell you now");
        response.Add("Outlook not so good");
        response.Add("Very doubtful");
        response.Add("Not at the moment");

        int ran = randResponse.Next(0, response.Count);
        answer = response[ran];

        return answer;
    }
}
