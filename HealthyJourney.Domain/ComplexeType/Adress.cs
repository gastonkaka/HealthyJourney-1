using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

    }
}
