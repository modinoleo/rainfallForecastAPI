using RainfallForecastAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Services.Contracts
{
    public interface IRainfallForecastService
    {
        Task<RainfallReadingResponse> GetReadingsByStationId(string stationId, int count);
    }
}
