using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class ServiceProviderBadge
    {
        [Key, Column(Order = 0)]
        public int BadgeId { get; set; }
        [Key, Column(Order = 1)]
        public int ServiceProviderId { get; set; }


        [Display(Name = "obtention date")] //lors de la generation du formulaire par l' ASP
        [DataType(DataType.DateTime)]
        public DateTime DateObtention { get; set; }

        virtual public ServiceProvider ServiceProvider { get; set; }
        virtual public Badge Badge { get; set; }

      
    }
}
