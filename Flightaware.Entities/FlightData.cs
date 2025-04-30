using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Entities
{
    public class FlightData
    {
        #region Properties

        [JsonProperty("flights")]
        public List<Flight> Flights { get; set; }

        [JsonProperty("links")]
        public object Links { get; set; }

        [JsonProperty("num_pages")]
        public int NumPages { get; set; }
        #endregion
    }
}
