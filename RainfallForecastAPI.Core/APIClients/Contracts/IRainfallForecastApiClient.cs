using RainfallForecastAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.APIClients.Contracts
{
    public interface IRainfallForecastApiClient
    {
        public Task<RainfallReadingItems> GetReadingsByStationId(string stationId, int count);
    }
}
