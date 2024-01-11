using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen.Service.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public List<string> Korean = new() { "10 Butchers", "Yogi Korean BBQ", "Han Sung BBQ", "Seoul Soon Dobu", "Goku Korean BBQ and Hot Pot", "Oz Korean", "Daikon Korean BBQ", "Blue House Korean BBQ", "Bullta K - BBQ & Club", "Gen Korean BBQ" };

    public List<string> Sushi = new() { "Mikuni's", "M Bistro", "Komachi", "Raw Sushi Bistro", "Domo Japanese Grill & Bar", "Shirasoni Japanese Restaurant", "Fuji Sushi", "Cocoro Bistro Sushi Bar", "Misaki Sushi & Bar", "Shomi Japanese Cuisine" };

    public List<string> FastFood = new() { "Wingstop", "Jack-In-The-Box", "In-N-Out Burger", "Raising Cane's Chicken Fingers", "Chik-Fil-A", "Frosty's Burgers", "Popeyes Louisiana Kitchen", "Sonic's Drive-In", "Taco Bell", "Wendy's" };
    public Random resRan = new Random();

    public string Food(string category)
    {
        if (category.ToLower() == "sushi")
        {
            return Sushi[resRan.Next(0, 10)];
        }
        if (category.ToLower() == "fast food")
        {
            return FastFood[resRan.Next(0,10)];
        }
        if (category.ToLower() == "korean")
        {
            return Korean[resRan.Next(0,10)];
        }
        else
        {
            return "Invalid food category. Please enter Sushi, Fast Food, or Korean";
        }
    }
}
