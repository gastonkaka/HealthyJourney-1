using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class InfosSpeciality
    {
        [Key, Column(Order = 0)]
        public int SpecialityId { get; set; }
        [Key, Column(Order = 1)]
        public string InfosId { get; set; }


        [Display(Name = "obtention date")] //lors de la generation du formulaire par l' ASP
        [DataType(DataType.DateTime)]
        public DateTime DateObtention { get; set; }

        virtual public Infos Infos { get; set; }
        virtual public Speciality Speciality { get; set; }

      
    }
}
