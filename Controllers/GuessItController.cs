using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    public Random randNum = new Random();
    [HttpGet]
    [Route("Easy/{easy}")]
   
    public string EasyMode(string easy)
    {

        int correctNum = randNum.Next(1, 11);

        bool parse = Int32.TryParse(easy, out int one);

        if (parse)
        {
            if (one < 1 || one > 11)
            {
                return "Invalid input. Please enter a number between 1 and 10.";
            }
            if (one < correctNum)
            {
                return $"{one} is less than the correct number";
            }
            else if (one > correctNum)
            {
                return $"{one} is greater than the correct number";
            }
            else
            {
                return $"{one} is the correct number";
            }
        }
        else
        {
            return "Invalid input. Please enter an actual number.";
        }

    }

    [HttpGet]
    [Route("Medium/{medium}")]
    public string MediumMode(string medium)
    {
        int correctNum = randNum.Next(1, 51);

        bool parse = Int32.TryParse(medium, out int one);

        if (parse)
        {
            if (one < 1 || one > 51)
            {
                return "Invalid input. Please enter a number between 1 and 50.";
            }
            if (one < correctNum)
            {
                return $"{one} is less than the correct number";
            }
            else if (one > correctNum)
            {
                return $"{one} is greater than the correct number";
            }
            else
            {
                return $"{one} is the correct number";
            }
        }
        else
        {
            return "Invalid input. Please enter an actual number.";
        }

    }

    [HttpGet]
    [Route("Hard/{hard}")]
    public string HardMode(string hard)
    {
        int correctNum = randNum.Next(1, 101);

        bool parse = Int32.TryParse(hard, out int one);

        if (parse)
        {
            if (one < 1 || one > 51)
            {
                return "Invalid input. Please enter a number between 1 and 100.";
            }
            if (one < correctNum)
            {
                return $"{one} is less than the correct number";
            }
            else if (one > correctNum)
            {
                return $"{one} is greater than the correct number";
            }
            else
            {
                return $"{one} is the correct number";
            }
        }
        else
        {
            return "Invalid input. Please enter an actual number.";
        }

    }

}
