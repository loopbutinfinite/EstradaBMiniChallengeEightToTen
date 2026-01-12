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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _GuessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _GuessItServices = guessItServices;
        }

        [HttpPost]
        [Route("GuessItGameEasy/{userInput}")]
        public string RunEasyMode(string userInput)
        {
            return _GuessItServices.GuessItGameEasy(userInput);
        }
        [HttpPost]
        [Route("GuessItGameMedium/{userInputMed}")]
        public string RunMediumMode(string userInputMed)
        {
            return _GuessItServices.GuessItGameMedium(userInputMed);
        }
        [HttpPost]
        [Route("GuessItGameHard/{userInputHard}")]
        public string RunHardMode(string userInputHard)
        {
            return _GuessItServices.GuessItGameHard(userInputHard);
        }
    }
}