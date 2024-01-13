using RainfallForecastAPI.Core.APIClients.Contracts;
using RainfallForecastAPI.Infrastructure.APIClient.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Tests.Infrastructure.APIClient
{
    [TestClass]
    public class RainfallForecastAPIClientTests: APIClientBaseTests
    {
        protected IRainfallForecastApiClient? _rainfallForecastApiClient;

        [TestInitialize]
        public void Initialize()
        {
            if (_rainfallApiOptions == null) throw new NullReferenceException();
            if (_httpClient == null) throw new NullReferenceException();

            _rainfallForecastApiClient = new RainfallForecastApiClient(_httpClient,_rainfallApiOptions);
        }
        [TestMethod]
        public async Task GetReadingsByStationId_ShouldReturnReadings()
        {
            if(_rainfallForecastApiClient == null) throw new NullReferenceException();

            var result = await _rainfallForecastApiClient.GetReadingsByStationId("E7050", 10);

            Assert.IsNotNull(result);
        }
    }
}
