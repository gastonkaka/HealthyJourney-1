using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class UserMetadata
    {
        [Key]
        public int Id { get; set; }
        public string file { get; set; }
        virtual public User User { get; set; }
    }
}
