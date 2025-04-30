using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flightaware.Entities
{
    public class LastPosition
    {
        #region Properties

        /// <summary> Identificador completo del vuelo en el sistema FlightAware.</summary>
        [JsonProperty("fa_flight_id")]
        public string FaFlightId { get; set; }

        /// <summary>Latitud de la última posición registrada.</summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>Longitud de la última posición registrada.</summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary> Altitud actual del vuelo en pies.</summary>
        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        /// <summary>Cambio de altitud indicado.</summary>
        [JsonProperty("altitude_change")]
        public string AltitudeChange { get; set; }

        /// <summary>Velocidad en tierra de la aeronave (en nudos).</summary>
        [JsonProperty("groundspeed")]
        public int GroundSpeed { get; set; }

        /// <summary>Dirección del vuelo en grados (0 a 360).</summary>
        [JsonProperty("heading")]
        public int Heading { get; set; }

        /// <summary>Marca de tiempo de la última posición registrada.</summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>Tipo de actualización de la posición.</summary>
        [JsonProperty("update_type")]
        public string UpdateType { get; set; }

        #endregion
    }
}
