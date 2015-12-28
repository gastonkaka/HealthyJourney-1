using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Service
{
    public class CommentServices : ICommentServices
    {
        IUnitOfWork uow = null;

        public CommentServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

        public void CreateComment(Comment c)
        {
            uow.CommentRepository.Add(c);
            uow.Commit();
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return uow.CommentRepository.GetAll().ToList();
        }

        public IEnumerable<Comment> GetCommentsByUserId(string InfosId)
        {
            return uow.CommentRepository.GetCommentsByUserId(InfosId);
        }

        public IEnumerable<Comment> GetCommentsByForumId(int ForumId)
        {
            return uow.CommentRepository.GetMany(u => u.Forum.ForumId.Equals(ForumId)).ToList();
        }
    }
}
