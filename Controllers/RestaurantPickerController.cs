using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Service.RestaurantPicker;

namespace MiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPicker;

    public RestaurantPickerController(IRestaurantPickerService restaurantPicker)
    {
        _restaurantPicker = restaurantPicker;
    }

    [HttpGet]
    [Route("category/{category}")]
    public string Food(string category)
    {
        return _restaurantPicker.Food(category);
    }
}
