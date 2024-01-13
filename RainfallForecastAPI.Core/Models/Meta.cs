using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Models
{
    public class Meta
    {
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
        [JsonPropertyName("licence")]
        public string Licence { get; set; }
        [JsonPropertyName("documentation")]
        public string Documentation { get; set; }
        [JsonPropertyName("version")]
        public string Version { get; set; }
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
        [JsonPropertyName("hasFormat")]
        public List<string> HasFormat { get; set; }
    }
}
