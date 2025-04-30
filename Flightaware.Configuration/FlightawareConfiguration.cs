using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Configuration
{
    public static class FlightawareConfiguration
    {
        //metodos que devuelvan datos de configuracion api, url -> client
        /// <summary>
        /// Devuelve la clave de API de Flightaware.
        /// </summary>
        public static string GetApiKey()
        {
            string ret = ConfigurationManager.AppSettings["FlightawareApiKey"];
            if (string.IsNullOrWhiteSpace(ret))
                throw new InvalidOperationException("Falta la clave de configuración: FlightawareApiKey.");
            return ret;
        }

        /// <summary>
        /// Devuelve la URL base de la API de Flightaware.
        /// </summary>
        public static string GetBaseUrl()
        {
            string ret = ConfigurationManager.AppSettings["FlightawareBaseUrl"];
            if (string.IsNullOrWhiteSpace(ret))
                throw new InvalidOperationException("Falta la clave de configuración: FlightawareBaseUrl.");
            return ret;
        }
    }
}

