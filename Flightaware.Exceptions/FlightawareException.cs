using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightaware.Exceptions
{
    /// <summary>
    /// Excepción personalizada para manejar errores específicos de la API de FlightAware.
    /// </summary>
    public class FlightawareException: Exception
    {
     
            /// <summary>
            /// Título descriptivo del error devuelto por la API.
            /// </summary>
            public string Title { get; }

            /// <summary>
            /// Razón o código de error devuelto por la API.
            /// </summary>
            public string Reason { get; }

            /// <summary>
            /// Detalle del error proporcionado por la API.
            /// </summary>
            public string Detail { get; }

            /// <summary>
            /// Código HTTP asociado al error.
            /// </summary>
            public int Status { get; }

            public FlightawareException(string title, string reason, string detail, int status)
                : base(detail)
            {
                Title = title;
                Reason = reason;
                Detail = detail;
                Status = status;
            }

            // Constructor alternativo para errores encadenados.
            public FlightawareException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        
    }
}
