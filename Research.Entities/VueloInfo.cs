using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Entities
{
    public class VueloInfo
    {
        public string NumeroVuelo { get; set; }
        public string Estado { get; set; }
        public string HoraEstimaArribo { get; set; }
        public string HoraArribo { get; set; }
        public DateTime HoraEstimaArriboLocal { get; set; }
        public DateTime HoraArriboLocal { get; set; }
    }
}
