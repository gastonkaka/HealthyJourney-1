using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        IDatabaseFactory dbf = null;
        HealthyJourneyContext ctx = null;
        public CommentRepository(IDatabaseFactory dbf) : base(dbf)
        {
            this.dbf = dbf;
            ctx = dbf.DataContext;
        }

        public IEnumerable<Comment> GetCommentsByUserId(string InfosId)
        {
            return ctx.Comments.Where(p => p.User.Id.Equals(InfosId)).ToList();
        }

        public IEnumerable<Comment> GetCommentsByForumId(int ForumId)
        {
            return ctx.Comments.Where(p => p.Forum.ForumId.Equals(ForumId)).ToList();
        }

    }

    public interface ICommentRepository : IRepository<Comment>
    {
        IEnumerable<Comment> GetCommentsByUserId(string InfosId);
        IEnumerable<Comment> GetCommentsByForumId(int ForumId);
    }
}
