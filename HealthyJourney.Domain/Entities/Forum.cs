using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Forum
    {
        [Key]
        public int ForumId { get; set; }
       
        public string Title { get; set; }
        public string Content { get; set; }
        public string Files { get; set; }
        public DateTime DateCreation { get; set; }
        virtual public User User { get; set; }
        virtual public IEnumerable<Comment> Comment { get; set; }
    }
}
