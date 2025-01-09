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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("EasyMode/{guess}")]
        public string EasyMode(string guess)
        {
            return _guessItServices.GuessItEasy(guess);
        }

        [HttpGet]
        [Route("MediumMode/{guess}")]
        public string MediumMode(string guess)
        {
            return _guessItServices.GuessItMedium(guess);
        }

        [HttpGet]
        [Route("HardMode/{guess}")]
        public string HardMode(string guess)
        {
            return _guessItServices.GuessItHard(guess);
        }
    }
}