using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Models
{
    public class RainfallReadingItems
    {
        [JsonPropertyName("@context")]
        public string Context { get; set; } = string.Empty;
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } = new();

        [JsonPropertyName("items")]
        public List<RainfallReading> Items { get; set; } = new();
    }
}
