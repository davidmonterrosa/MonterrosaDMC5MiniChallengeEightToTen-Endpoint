using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Services;

namespace MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{restaurantCategory}")]

        public string RestaurantPicker(string restaurantCategory)
        {
            return _restaurantPickerServices.RestaurantPicker(restaurantCategory);
        }
    }
}