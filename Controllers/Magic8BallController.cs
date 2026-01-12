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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _Magic8BallServices;

        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
            _Magic8BallServices = magic8BallServices;
        }

        [HttpPost]
        [Route("Magic8Ball/{userQuestion}")]
        public string Magic8BallReturnResponses(string userQuestion)
        {
            return _Magic8BallServices.Magic8BallResponse(userQuestion);
        }
    }
}