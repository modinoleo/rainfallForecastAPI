using RainfallForecastAPI.Core.APIClients.Contracts;
using RainfallForecastAPI.Core.Services.Contracts;
using RainfallForecastAPI.Core.Services.Implementations;
using RainfallForecastAPI.Infrastructure.APIClient.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Tests.Infrastructure.Services
{
    [TestClass]
    public class RainfallForecastServiceTests : ServiceBaseTests
    {
        protected IRainfallForecastService? _rainfallForecastService;
        private string stationId = "E7050";
        private int count = 10;
        [TestInitialize]
        public void Initialize()
        {
            if (_rainfallApiOptions == null) throw new NullReferenceException();
            if (_httpClient == null) throw new NullReferenceException();

            var _rainfallForecastApiClient = new RainfallForecastApiClient(_httpClient, _rainfallApiOptions);
            _rainfallForecastService = new RainfallForecastService(_rainfallForecastApiClient);
        }
        [TestMethod]
        public async Task GetReadingsByStationId_ShouldReturnValidResponse()
        {

            if (_rainfallForecastService == null) throw new NullReferenceException();

            var result = await _rainfallForecastService.GetReadingsByStationId(stationId, count);
            Assert.IsNotNull(result);
        }
    }
}
