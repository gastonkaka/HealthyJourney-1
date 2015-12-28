using HealthyJourney.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private HealthyJourneyContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }



        private IBadgeRepository badgeRepository;
        public IBadgeRepository BadgeRepository
        {
            get { return badgeRepository = new BadgeRepository(dbFactory); }
        }



        private ISpecialityRepository specialityRepository;
        public ISpecialityRepository SpecialityRepository
        {
            get { return specialityRepository = new SpecialityRepository(dbFactory); }
        }



        private IMedicalRecordRepository medicalRecordRepository;
        public IMedicalRecordRepository MedicalRecordRepository
        {
            get { return medicalRecordRepository = new MedicalRecordRepository(dbFactory); }
        }



        
        private UserRepository userRepository;
         public IUserRepository UserRepository
        {
            get { return userRepository = new UserRepository(dbFactory); }
        }

        private InfosRepository infosRepository;
        public IInfosRepository InfosRepository
        {
            get { return infosRepository = new InfosRepository(dbFactory); }
        }

        private ICommentRepository commentRepository;
        public ICommentRepository CommentRepository
        {
            get { return commentRepository = new CommentRepository(dbFactory); }
        }

        private IForumRepository forumRepository;
        public IForumRepository ForumRepository
        {
            get { return forumRepository = new ForumRepository(dbFactory); }
        }


        protected HealthyJourneyContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

  
        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }
    }

}
