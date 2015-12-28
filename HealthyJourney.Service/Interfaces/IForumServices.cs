using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Service
{
    public interface IForumServices
    {
        void AddForum(Forum frm);
        void CreateForum(Forum f);
        IEnumerable<Forum> GetAllForums();
        Forum GetForumById(int ForumId);
        IEnumerable<Comment> GetAllCommentByForumId(int id);
    }
}
