using Microsoft.AspNetCore.Mvc;

namespace MobiileServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet(Name = "GetWeatherForecast")]
        public bool Get()
        {
            return true;
        }
    }
}
