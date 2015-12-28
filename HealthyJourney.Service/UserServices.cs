using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Data.Infrastructure;

namespace HealthyJourney.Service
{
    public class UserServices : IUserServices
    {
        IUnitOfWork uow = null;
        public UserServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

        public void AddInfos(Infos infos)
        {
            try
            {
               
                uow.InfosRepository.Add(infos);
                uow.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Infos> GetAllInfos()
        {
            return uow.InfosRepository.GetAll().ToList();
        }

        public IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id)
        {
            var test = uow.InfosRepository.GetAllInfosBySpecialityId(id);
            //test.Count();
            return test;

        }

        public IEnumerable<User> GetAllUsers()
        {
            return uow.UserRepository.GetAll().ToList();
        }

        public Infos GetById(string id)
        {
            return uow.InfosRepository.GetById(id);
        }

        public List<MedicalRecord> GetMedicalRecordsByUserId(int id)
        {
            return uow.MedicalRecordRepository.GetMany(u => u.User.Id.Equals(id)).ToList();
        }
    }
}
