using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        virtual public IEnumerable<Formular> Formulars { get; set; }

    }
}
