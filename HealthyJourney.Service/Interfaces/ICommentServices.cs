using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Service
{
    public interface ICommentServices
    {
        void CreateComment(Comment c);
        IEnumerable<Comment> GetAllComments();
        IEnumerable<Comment> GetCommentsByUserId(string UserId);
        IEnumerable<Comment> GetCommentsByForumId(int ForumId);
    }
}
