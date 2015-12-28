using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyJourney.Angular.Models
{
    public class ForumViewModel
    {
        public int ForumId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Files { get; set; }
        public DateTime DateCreation { get; set; }
        virtual public User User { get; set; }
        virtual public IEnumerable<Comment> Comment { get; set; }
    }
}