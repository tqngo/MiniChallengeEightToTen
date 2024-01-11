using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuessItController : ControllerBase
{

}



// bool playAgain = true;

// while (playAgain)
// {

//     Random random = new Random();
//     bool again = true;
//     bool begin = true;
//     bool reEasy = true;
//     bool reMed = true;
//     bool reHard = true;
//     bool reCustom = true;
//     string diff = "";
//     int tries = 1;
//     string tryAgain = "no";

//     while (begin)
//     {
//         Console.WriteLine("Lets play a game, choose a difficulty: Easy || Medium || Hard || Custom.");
//         diff = Console.ReadLine().ToLower();
//         if (diff == "easy" || diff == "medium" || diff == "hard" || diff == "custom")
//         {
//             begin = false;
//         }
//         else
//         {
//             Console.WriteLine("You entered an invalid difficulty.");
//         }
//     }
//     if (diff == "easy")
//     {
//         Console.WriteLine($"You have chosen {diff}. Please choose a number between 1 - 10.");
//         int answer = random.Next(1, 11);
//         while (reEasy)
//         {
//             string guess = Console.ReadLine();
//             int realNum;
//             bool parse = false;
//             if (parse = Int32.TryParse(guess, out realNum))
//             {
//                 if (realNum > answer)
//                 {
//                     Console.WriteLine($"{realNum} is greater than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;
//                     reEasy = true;

//                 }
//                 else if (realNum < answer)
//                 {
//                     Console.WriteLine($"{realNum} is less than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;
//                     reEasy = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Your guess was correct.");
//                     Console.WriteLine($"The correct number is {answer}.");
//                     Console.WriteLine($"You've attemped {tries} time(s).");
//                     reEasy = false;
//                 }
//             }
//             else
//                 Console.WriteLine("Invalid input. Enter a number.");
//         }
//     }

//     if (diff == "medium")
//     {
//         Console.WriteLine($"You have chosen {diff}. Please choose a number between 1 - 50");
//         int answer = random.Next(1, 51);
//         while (reMed)
//         {
//             string guess = Console.ReadLine();
//             int realNum;
//             bool parse = false;
//             if (parse = Int32.TryParse(guess, out realNum))
//             {
//                 if (realNum > answer)
//                 {
//                     Console.WriteLine($"{realNum} is greater than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;
//                     reMed = true;

//                 }
//                 else if (realNum < answer)
//                 {
//                     Console.WriteLine($"{realNum} is less than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;

//                     reMed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Your guess was correct.");
//                     Console.WriteLine($"The correct number is {answer}.");
//                     Console.WriteLine($"You've attempted {tries} time(s).");
//                     reMed = false;
//                 }
//             }
//             else
//                 Console.WriteLine("Invalid input. Enter a number.");
//         }
//     }

//     if (diff == "hard")
//     {
//         Console.WriteLine($"You have chosen {diff}. Please choose a number between 1 - 100.");
//         int answer = random.Next(1, 101);
//         while (reHard)
//         {
//             string guess = Console.ReadLine();
//             int realNum;
//             bool parse = false;
//             if (parse = Int32.TryParse(guess, out realNum))
//             {
//                 if (realNum > answer)
//                 {
//                     Console.WriteLine($"{realNum} is greater than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;
//                     reHard = true;

//                 }
//                 else if (realNum < answer)
//                 {
//                     Console.WriteLine($"{realNum} is less than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;

//                     reHard = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Your guess was correct.");
//                     Console.WriteLine($"The correct number is {answer}.");
//                     Console.WriteLine($"You've attempted {tries} time(s).");
//                     reHard = false;
//                 }
//             }
//             else
//                 Console.WriteLine("Invalid input. Enter a number.");
//         }
//     }


//     if (diff == "custom")
//     {
//         Console.WriteLine($"You have chosen {diff}. Please select a minimum value.");
//         int minChoice;
//         int maxChoice;
//         bool parse1 = true;
//         bool parse2 = true;
//         while(parse1 !=Int32.TryParse(Console.ReadLine(), out minChoice)){
//             Console.WriteLine("Please input a valid minimum number.");
//         }
//         Console.WriteLine("You've chosen a minimum number. Now choose a maximum number.");
//         while(parse2 != Int32.TryParse(Console.ReadLine(), out maxChoice))
//         {
//             Console.WriteLine("Please input a valid maximum number.");
//         }
//         Console.WriteLine("Your minimum and maximum has been chosen.");
//         int answer = random.Next(minChoice, maxChoice+1);
//         Console.WriteLine("Please enter your guess. Goodluck!");      

//         while (reCustom)
//         {
//             string guess = Console.ReadLine();
//             int realNum;
//             bool cParse = false;
//             if (cParse = Int32.TryParse(guess, out realNum))
//             {
//                 if (realNum > answer)
//                 {
//                     Console.WriteLine($"{realNum} is greater than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;
//                     reCustom = true;

//                 }
//                 else if (realNum < answer)
//                 {
//                     Console.WriteLine($"{realNum} is less than the actual number.");
//                     Console.WriteLine($"You've attempted {tries} time(s). Please guess another number.");
//                     tries++;

//                     reCustom = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Your guess was correct.");
//                     Console.WriteLine($"The correct guess was {answer}.");
//                     Console.WriteLine($"You've attempted {tries} time(s).");
//                     reCustom = false;
//                 }
//             }
//             else
//                 Console.WriteLine("Invalid input. Enter a number.");
//         }
//     }

//     while (again)
//     {
//         Console.WriteLine("Do you want to play the guessing game again?");
//         tryAgain = Console.ReadLine().ToLower();
//         if (tryAgain == "no")
//         {
//             playAgain = false;
//             Console.WriteLine("Thank you for playing!");
//             again = false;
//         }
//         else if (tryAgain == "yes")
//         {
//             playAgain = true;
//             again = false;
//             begin = false;

//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter yes or no.");
//         }
//     }
// }

