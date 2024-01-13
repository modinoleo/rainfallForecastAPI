using RainfallForecastAPI.Core.APIClients.Contracts;
using RainfallForecastAPI.Core.Models;
using RainfallForecastAPI.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Services.Implementations
{
    public class RainfallForecastService : IRainfallForecastService
    {
        private readonly IRainfallForecastApiClient _rainfallForecastApiClient;
        public RainfallForecastService(IRainfallForecastApiClient rainfallForecastApiClient) 
        {
            _rainfallForecastApiClient = rainfallForecastApiClient;
        }    
        public async Task<RainfallReadingResponse> GetReadingsByStationId(string stationId, int count)
        {
            var rainfallReading = await _rainfallForecastApiClient.GetReadingsByStationId(stationId, count);

            return new RainfallReadingResponse
            {
                Readings = rainfallReading.Items
            };
        }
    }
}
