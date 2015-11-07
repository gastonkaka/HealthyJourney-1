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
        private IUserRepository userRepository;
        public IUserRepository UserRepository
        {
            get { return userRepository = new UserRepository(dbFactory); }
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
