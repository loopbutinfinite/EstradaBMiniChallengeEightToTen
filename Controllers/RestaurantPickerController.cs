using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_5_Net_8_and_Api_Build_Along.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day_5_Net_8_and_Api_Build_Along.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _RestaurantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _RestaurantPickerServices = restaurantPickerServices;
        }
        [HttpPost]
        [Route("IndianKoreanGreek/{userCategory}")]
        public string RunRestaurantPicker(string userCategory)
        {
            return _RestaurantPickerServices.RestaurantPicker(userCategory);
        }
    }
}