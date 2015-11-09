using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class FeedBack
    {
        public int Id { get; set; }
        virtual public Client Client { get; set; }
        public int? ClientId { get; set; }
        public string Title { get; set; }
        public string Descripion { get; set; }
    }
}
