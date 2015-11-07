using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        [Display(Name = "creation date")] //lors de la generation du formulaire par l' ASP
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "the description is required")]
        public string Description { get; set; }

        virtual public Badge speciality { get; set; }
        virtual public Client Client { get; set; }
    }
}
