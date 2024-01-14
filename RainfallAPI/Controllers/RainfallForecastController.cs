using Microsoft.AspNetCore.Mvc;
using RainfallForecastAPI.Core.Models;
using RainfallForecastAPI.Core.Services.Contracts;
using System.Net;

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
        public async Task<ActionResult<RainfallReadingResponse>> GetRainfallReadings(string stationId, [FromQuery] int count = 10)
        {
            try
            {
                var readings = await _rainfallForecastService.GetReadingsByStationId(stationId, count);

                if(readings.Readings.Count > 0) {
                    return readings;
                }
                else
                {
                    return NotFound("No readings found for the specified stationId");
                }
            }
            catch (HttpRequestException)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Internal server error");
            }

        }
    }
}
