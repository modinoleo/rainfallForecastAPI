using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Models
{
    public class RainfallReading
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }
        [JsonPropertyName("measure")]
        public string Measure { get; set; } = string.Empty;
        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
