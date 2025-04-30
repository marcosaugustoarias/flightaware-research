using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Entities
{
    public class ErrorResponse
    {
        /// <summary>
        /// Título descriptivo del error.
        /// Ejemplo: "Incorrect parameter(s)", "Invalid", "Invalid argument"
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Código de razón del error, usado por la API.
        /// Ejemplo: "INVALID_ARGUMENT", "INVALID", "NOT_FOUND"
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Información detallada sobre el error específico.
        /// Ejemplos:
        /// - "Id may be missing or may not be fa_flight_id format"
        /// - "date format for end, must be in ISO8601"
        /// - "Invalid start bound: time is too far in the future (limit: 2 days)"
        /// - "Invalid start bound: time is too far in the past (limit: 10 days)"
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Código de estado HTTP asociado al error.
        /// Ejemplo: 400 (Bad Request), 404 (Not Found)
        /// </summary>
        public int Status { get; set; }
    }
}

