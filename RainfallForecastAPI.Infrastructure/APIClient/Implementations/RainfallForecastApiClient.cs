using Microsoft.Extensions.Options;
using RainfallForecastAPI.Core.APIClients.Contracts;
using RainfallForecastAPI.Core.Configurations;
using RainfallForecastAPI.Core.Models;
using System.Text.Json;

namespace RainfallForecastAPI.Infrastructure.APIClient.Implementations
{
    public class RainfallForecastApiClient : IRainfallForecastApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        public RainfallForecastApiClient(HttpClient httpClient, IOptions<RainfallApiOptions> options)
        {
            _httpClient = new HttpClient();
            _baseAddress = options.Value.BaseAddress;

            if (string.IsNullOrEmpty(_baseAddress))
            {
                throw new InvalidOperationException("BaseAddress is not configured.");
            }
            _httpClient.BaseAddress = new Uri(_baseAddress);

        }
        public async Task<RainfallReadingItems> GetReadingsByStationId(string stationId, int count)
        {

            var response = await _httpClient.GetAsync($"/flood-monitoring/id/stations/{stationId}/readings?latest");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var resultObject = JsonSerializer.Deserialize<RainfallReadingItems>(content);
                return resultObject ?? new RainfallReadingItems();
            }
            else
            {
                throw new HttpRequestException(content,null,response.StatusCode);
            }
        }
    }
}
