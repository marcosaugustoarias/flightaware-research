using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Entities
{
    public class Airport
    {
        #region Properties

        /// <summary> Código del aeropuerto.</summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary> Código ICAO del aeropuerto.</summary>
        [JsonProperty("code_icao")]
        public string CodeIcao { get; set; }

        /// <summary> Código IATA del aeropuerto.</summary>
        [JsonProperty("code_iata")]
        public string CodeIata { get; set; }

        /// <summary> Nombre completo del aeropuerto.</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary> Ciudad donde se encuentra el aeropuerto.</summary>
        [JsonProperty("city")]
        public string City { get; set; }

        #endregion
    }
}
