using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Entities
{
   public class Flight
    {
        #region Properties


        /// <summary>Identificador del vuelo (código del operador seguido del número de vuelo o la matrícula de la aeronave).</summary>
        [JsonProperty("ident")]
        public string Ident { get; set; }

        /// <summary>Identificador ICAO del vuelo.</summary>
        [JsonProperty("ident_icao")]
        public string IdentIcao { get; set; }

        /// <summary>Identificador IATA del vuelo.</summary>
        [JsonProperty("ident_iata")]
        public string IdentIata { get; set; }

        /// <summary>Nombre del operador de la aeronave.</summary>
        [JsonProperty("operator")]
        public string OperatorName { get; set; }

        /// <summary>Número de vuelo sin prefijo de operador.</summary>
        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        /// <summary>Matrícula de la aeronave (tail number).</summary>
        [JsonProperty("registration")]
        public string Registration { get; set; }

        /// <summary>Información del aeropuerto de origen.</summary>
        [JsonProperty("origin")]
        public Airport Origin { get; set; }

        /// <summary>Información del aeropuerto de destino.</summary>
        [JsonProperty("destination")]
        public Airport Destination { get; set; }

        /// <summary>Hora programada de salida desde la puerta de embarque.</summary>
        [JsonProperty("scheduled_out")]
        public DateTime? ScheduledOut { get; set; }

        /// <summary>Hora estimada de salida desde la puerta de embarque.</summary>
        [JsonProperty("estimated_out")]
        public DateTime? EstimatedOut { get; set; }

        /// <summary>Hora real de salida desde la puerta de embarque.</summary>
        [JsonProperty("actual_out")]
        public DateTime? ActualOut { get; set; }

        /// <summary>Hora programada de despegue (ruedas fuera de pista).</summary>
        [JsonProperty("scheduled_off")]
        public DateTime? ScheduledOff { get; set; }

        /// <summary>Hora estimada de despegue (ruedas fuera de pista).</summary>
        [JsonProperty("estimated_off")]
        public DateTime? EstimatedOff { get; set; }

        /// <summary>Hora real de despegue (ruedas fuera de pista).</summary>
        [JsonProperty("actual_off")]
        public DateTime? ActualOff { get; set; }

        /// <summary>Hora programada de aterrizaje (ruedas sobre pista).</summary>
        [JsonProperty("scheduled_on")]
        public DateTime? ScheduledOn { get; set; }

        /// <summary>Hora estimada de aterrizaje (ruedas sobre pista).</summary>
        [JsonProperty("estimated_on")]
        public DateTime? EstimatedOn { get; set; }

        /// <summary>Hora real de aterrizaje (ruedas sobre pista).</summary>
        [JsonProperty("actual_on")]
        public DateTime? ActualOn { get; set; }

        /// <summary>Hora programada de llegada a la puerta de desembarque.</summary>
        [JsonProperty("scheduled_in")]
        public DateTime? ScheduledIn { get; set; }

        /// <summary>Hora estimada de llegada a la puerta de desembarque.</summary>
        [JsonProperty("estimated_in")]
        public DateTime? EstimatedIn { get; set; }

        /// <summary>Hora real de llegada a la puerta de desembarque.</summary>
        [JsonProperty("actual_in")]
        public DateTime? ActualIn { get; set; }

        /// <summary>Estado actual del vuelo (Scheduled, En Route, Landed, etc.).</summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>Tipo de aeronave (código ICAO).</summary>
        [JsonProperty("aircraft_type")]
        public string AircraftType { get; set; }

        /// <summary>Distancia planificada de la ruta en millas náuticas.</summary>
        [JsonProperty("route_distance")]
        public int RouteDistance { get; set; }

        /// <summary>Terminal de salida en el aeropuerto de origen.</summary>
        [JsonProperty("terminal_origin")]
        public string TerminalOrigin { get; set; }

        /// <summary>Terminal de llegada en el aeropuerto de destino.</summary>
        [JsonProperty("terminal_destination")]
        public string TerminalDestination { get; set; }

        #endregion
    }

}
