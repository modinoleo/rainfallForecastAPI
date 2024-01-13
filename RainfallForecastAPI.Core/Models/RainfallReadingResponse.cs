using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallForecastAPI.Core.Models
{
    public class RainfallReadingResponse
    {
        public List<RainfallReading> Readings { get; set; } = new();
    }
}
