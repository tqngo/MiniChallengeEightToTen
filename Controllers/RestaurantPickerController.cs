using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    public List<string> Korean = new() { "10 Butchers", "Yogi Korean BBQ", "Han Sung BBQ", "Seoul Soon Dobu", "Goku Korean BBQ and Hot Pot", "Oz Korean", "Daikon Korean BBQ", "Blue House Korean BBQ", "Bullta K - BBQ & Club", "Gen Korean BBQ" };

    public List<string> Sushi = new() { "Mikuni's", "M Bistro", "Komachi", "Raw", "Domo Japanese Grill & Bar", "Shirasoni Japanese Restaurant", "Fuji Sushi", "Cocoro Bistro Sushi Bar", "Misaki Sushi & Bar", "Shomi Japanese Cuisine" };

    public List<string> FastFood = new() { "Wingstop", "Jack-In-The-Box", "In-N-Out Burger", "Raising Cane's Chicken Fingers", "Chik-Fil-A", "Frosty's Burgers", "Popeyes Louisiana Kitchen", "Sonic's Drive-In", "Taco Bell", "Wendy's" };

    public Random resRan = new Random();

    [HttpGet]
    [Route("category/{category}")]
    public string Food(string category)
    {
        if (category.ToLower() == "sushi")
        {
            
            return Sushi[resRan.Next(1, 11)];
        }
        if (category.ToLower() == "fast food")
        {
            return FastFood[resRan.Next(1, 11)];
        }
        if (category.ToLower() == "korean")
        {
            return Korean[resRan.Next(1, 11)];
        }
        else
        {
            return "invalid food category. Please enter Sushi, FastFood, or Korean";
        }
    }
}




//     Console.WriteLine("I'm hungry, do you want Korean, Sushi, or Fast Food?");
//     string userCat = Console.ReadLine().ToLower();

//     if (userCat == "sushi")
//     {
//         Console.WriteLine($"You have chosen {userCat} So I chose we're going to {sushi[sushiFood]}");

//     }
//     else if (userCat == "korean")
//     {
//         Console.WriteLine($"You have chosen {userCat} So I chose we're going to {korean[koreanFood]}");
//     }
//     else if (userCat == "fast food")
//     {
//         Console.WriteLine($"You have chosen {userCat} So I chose we're going to {fastFood[fastF]}");
//     }
//     else
//     {
//         Console.WriteLine("You've inputted an invalid option");


//     }
//     bool failAgain = true;
//     while (failAgain)
//     {

//         Console.WriteLine("");
//         Console.WriteLine("Do you want to try again?");

//         bool again = true;
//         while (again)
//         {
//             string tryAgain = Console.ReadLine();
//             tryAgain = tryAgain.ToLower();
//             switch (tryAgain)
//             {
//                 case "yes":
//                 case "yep":
//                 case "yea":
//                 case "yeah":
//                     again = false;
//                     failAgain = false;
//                     break;

//                 case "no":
//                 case "nah":
//                 case "nope":
//                     playAgain = false;
//                     again = false;
//                     failAgain = false;
//                     Console.WriteLine("Thank you for playing!");
//                     break;

//                 default:
//                     playAgain = true;
//                     Console.WriteLine("Invalid input. Please input a correct answer.");
//                     break;

//             }

//         }

//     }
// }