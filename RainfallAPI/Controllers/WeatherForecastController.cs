using Microsoft.AspNetCore.Mvc;

namespace RainfallAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("id/{stationId}/readings")]
        public ActionResult<WeatherForecast> GetRainfallReadings(string stationId, [FromQuery] int count = 10)
        {
            // Implement logic here to fetch rainfall readings based on stationId and count
            // Construct and return a RainfallReadingResponse
            // Example:
            //var readings = _rainfallService.GetReadingsForStation(stationId, count);
            //var response = new RainfallReadingResponse { Readings = readings };
            return Ok(true);
        }
    }
}
