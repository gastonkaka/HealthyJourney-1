using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repositories
{
    public class ForumRepository : RepositoryBase<Forum>, IForumRepository
    {
        IDatabaseFactory dbf = null;
        HealthyJourneyContext ctx = null;
        public ForumRepository(IDatabaseFactory dbf) : base(dbf)
        {
            this.dbf = dbf;
            ctx = dbf.DataContext;
        }

        public IEnumerable<Comment> GetAllCommentByForumId(int id)
        {
            return ctx.Comments.Where(u => u.Forum.ForumId == id).ToList();
        }

    }

    public interface IForumRepository : IRepository<Forum>
    {
        IEnumerable<Comment> GetAllCommentByForumId(int id);

    }
}
