using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Service
{
    public class ForumServices : IForumServices
    {
        IUnitOfWork uow = null;

        public ForumServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

        public void AddForum(Forum frm)
        {
            try
            {
                uow.ForumRepository.Add(frm);
                uow.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateForum(Forum f)
        {
            uow.ForumRepository.Add(f);
            uow.Commit();
        }

        public IEnumerable<Forum> GetAllForums()
        {
            return uow.ForumRepository.GetAll().ToList();
        }

        public Forum GetForumById(int ForumId)
        {
            return uow.ForumRepository.GetById(ForumId);
        }

        public IEnumerable<Comment> GetAllCommentByForumId(int id)
        {
            return uow.ForumRepository.GetAllCommentByForumId(id);
        }

    }
}
