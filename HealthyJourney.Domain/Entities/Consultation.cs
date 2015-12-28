using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Consultation
    {

        [Display(Name = "creation date")] //lors de la generation du formulaire par l' ASP
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [Key, Column(Order = 0)]
        public int ClientId { get; set; }

        [Key, Column(Order = 1)]
        public int DoctorId { get; set; }

        virtual public User Client { get; set; }

        virtual public User Doctor { get; set; }
    }
}
