using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Formular
    {
        public int Id { get; set; }
        virtual public IEnumerable<Facture> Factures { get; set; }
        virtual public IEnumerable<Service> Services { get; set; }

    }
}
