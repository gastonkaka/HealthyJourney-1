using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        virtual public IEnumerable<Formular> Formulars { get; set; }

    }
}
