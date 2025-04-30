using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightaware.Client;
using Research.Entities;
using Flightaware.Entities;

namespace Research.Business
{
    public class VueloManager
    {

        public VueloInfo GetVueloInfo(string numeroVueloIata , DateTime fechaVuelo)
        {
            FlightawareClient _client = new FlightawareClient();
            var flightData = _client.GetFlightData(numeroVueloIata, fechaVuelo);

            return MapFlightDataToVueloInfo(flightData);
        }

        private VueloInfo MapFlightDataToVueloInfo(FlightData flightData)
        {
            var vuelo = flightData?.Flights?.FirstOrDefault();

            if (vuelo == null)
                return null;

            return new VueloInfo
            {
                NumeroVuelo = vuelo.IdentIata,
                Estado = vuelo.Status,
                HoraEstimaArribo = vuelo.EstimatedOn?.ToString("u"),
                HoraArribo = vuelo.ActualIn?.ToString("u")
            };
        }
    }
}

