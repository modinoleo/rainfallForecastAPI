using Microsoft.AspNetCore.Mvc;
using RainfallForecastAPI.Core.Models;
using RainfallForecastAPI.Core.Services.Contracts;

namespace RainfallAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainfallForecastController : ControllerBase
    {
        private readonly IRainfallForecastService _rainfallForecastService;
        public RainfallForecastController(IRainfallForecastService rainfallForecastService)
        {
            _rainfallForecastService = rainfallForecastService;
        }
        [HttpGet("id/{stationId}/readings")]
        public async Task<RainfallReadingResponse> GetRainfallReadings(string stationId, [FromQuery] int count = 10)
        {
           var readings = await _rainfallForecastService.GetReadingsByStationId(stationId, count);
           return readings;
        }
    }
}
