using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    //[Table("ServiceProvider")]
    public class Infos 
    {

        public string UserId { get; set; }
        public bool IsFull { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Thumbnail { get; set; }


        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }


        public IEnumerable<Forum> Forums { get; set; }

        public IEnumerable<Speciality> Specialities { get; set; }

        virtual public IEnumerable<Badge> badge { get; set; }

        virtual public User User { get; set; }
    }
}
