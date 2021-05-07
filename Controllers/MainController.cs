using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace serviceB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("service B Ok...");
        }

        [HttpGet("test")]
        public IActionResult GetTest(string someString)
        {
            _logger.LogInformation("Get test called!");
            return Ok($"You passed {someString} as parameter.");
        }
    }
}
