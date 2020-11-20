using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contracts;
namespace TrainingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Log Info Message");
            _logger.LogDebug("Log Debug Message");
            _logger.LogError("Log Error Message");
            _logger.LogWarn("Log Warn Message");

            return new string[] {"Eng","Rabeeb" };

        }
    }
}
