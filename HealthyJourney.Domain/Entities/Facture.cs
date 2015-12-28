using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Facture
    {
        [Key, Column(Order = 0)]
        public int ServiceId { get; set; }
        [Key, Column(Order = 1)]
        public int FormularId { get; set; }
        virtual public Formular Formular { get; set; }
        virtual public User User { get; set; }
    }
}
