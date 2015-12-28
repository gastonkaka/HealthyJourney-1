using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Badge
    {

        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime DateCreation { get; set; }

        [Range(1, 3, ErrorMessage = "3 is the maximum value")]
        public int Level { get; set; }
       
    }
}
