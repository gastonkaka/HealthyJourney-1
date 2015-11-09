using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Comment
    {
        [Key, Column(Order = 0)]
        public int ClientId { get; set; }
        [Key , Column(Order = 1)]
        public int ForumId { get; set; }
        virtual public Client Client { get; set; }
        virtual public Forum Forum { get; set; }
    }
}
