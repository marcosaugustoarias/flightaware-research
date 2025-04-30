using System;
using System.Net.Http;
using Newtonsoft.Json;
using Flightaware.Exceptions;
using Flightaware.Entities;
using Flightaware.Configuration;

namespace Flightaware.Client
{
 

    public class FlightawareClient
    {
        public FlightData GetFlightData(string idIata, DateTime date)
        {
            string apikey = FlightawareConfiguration.GetApiKey();
            string baseUrl = FlightawareConfiguration.GetBaseUrl();
            string start = date.ToString("yyyy-MM-dd") + "T00:00:00Z";
            string end = date.ToString("yyyy-MM-dd") + "T23:59:59Z";

            string uri = $"{baseUrl}/{idIata}?start={start}&end={end}&ident_type=designator";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(60);
                    client.DefaultRequestHeaders.Add("x-apikey", apikey);

                    HttpResponseMessage response = client.GetAsync(new Uri(uri)).Result;
                    string content = response.Content.ReadAsStringAsync().Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<FlightData>(content);
                    }
                    else
                    {
                        ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(content);
                        throw new FlightawareException(errorResponse.Title, errorResponse.Reason, errorResponse.Detail, errorResponse.Status);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled Exception: {ex.Message}");
                ex.Data["uri"] = uri;
                throw;
            }
        }
    }
}