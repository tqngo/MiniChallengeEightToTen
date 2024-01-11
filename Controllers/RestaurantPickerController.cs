using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantPickerController : ControllerBase
{

}


// bool playAgain = true;
// while (playAgain)
// {
//     Random restaurant = new Random();
//     restaurant = new Random();
//     int sushiFood = restaurant.Next(0, 10);
//     string[] sushi = new string[10];

//     sushi[0] = "Mikuni's";
//     sushi[1] = "M Bistro";
//     sushi[2] = "Komachi";
//     sushi[3] = "Raw";
//     sushi[4] = "Domo Japanese Grill & Bar";
//     sushi[5] = "Shirasoni Japanese Restaurant";
//     sushi[6] = "Fuji Sushi";
//     sushi[7] = "Cocoro Bistro Sushi Bar";
//     sushi[8] = "Misaki Sushi & Bar";
//     sushi[9] = "Shomi Japanese Cuisine";

//     int koreanFood = restaurant.Next(0, 10);
//     string[] korean = new string[10];
//     korean[0] = "10 Butchers";
//     korean[1] = "Yogi Korean BBQ";
//     korean[2] = "Han Sung BBQ";
//     korean[3] = "Seoul Soon Dobu";
//     korean[4] = "Goku Korean BBQ and Hot Pot";
//     korean[5] = "Oz Korean";
//     korean[6] = "Daikon Korean BBQ";
//     korean[7] = "Blue House Korean BBQ";
//     korean[8] = "Bullta K - BBQ & Club";
//     korean[9] = "Gen Korean BBQ";

//     int fastF = restaurant.Next(0, 10);
//     string[] fastFood = new string[10];
//     fastFood[0] = "WingStop";
//     fastFood[1] = "Jack-N-The Box";
//     fastFood[2] = "In-N-Out Burger";
//     fastFood[3] = "Raising Cane's Chicken Fingers";
//     fastFood[4] = "Chik-Fil-A";
//     fastFood[5] = "Frosty's Burgers";
//     fastFood[6] = "Popeyes Louisiana Kitchen";
//     fastFood[7] = "Sonic's Drive ";
//     fastFood[8] = "Taco Bell";
//     fastFood[9] = "Wendy's";




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