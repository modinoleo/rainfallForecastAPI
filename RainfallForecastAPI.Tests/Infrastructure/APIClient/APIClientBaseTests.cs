using Microsoft.Extensions.Options;
using RainfallForecastAPI.Core.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Tests.Infrastructure.APIClient
{
    public class APIClientBaseTests
    {
        protected IOptions<RainfallApiOptions>? _rainfallApiOptions;
        protected HttpClient? _httpClient;

        [TestInitialize] public void TestInitialize()
        {
            
            var rainfallApiOptions = Options.Create(new RainfallApiOptions { BaseAddress = "http://environment.data.gov.uk" });

            _rainfallApiOptions = rainfallApiOptions;
            _httpClient = new HttpClient();
        }
    }
}
