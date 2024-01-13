using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Models
{
    public class ErrorResponse
    {
        public string Message { get; set; } = string.Empty;
        public List<ErrorDetail> Detail { get; set; } = new();
    }
}
