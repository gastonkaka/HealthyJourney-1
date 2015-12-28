using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }
        virtual public User User { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Descripion { get; set; }
    }
}
