using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Data.Infrastructure;

namespace HealthyJourney.Service
{
    public class SpecialityServices : ISpecialityServices
    {
        IUnitOfWork uow = null;
        public SpecialityServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

       
        public void AddSpeciality(Speciality spe)
        {
            try
            {
                uow.SpecialityRepository.Add(spe);
                uow.Commit();

            }
            catch (Exception)
            {

                throw;
            }        }

        public IEnumerable<Speciality> GetAllSpecialities()
        {
           return uow.SpecialityRepository.GetAll().ToList();
        }

        //public List<User> GetByCity(string city)
        //{
        //    return uow.InfosRepository.GetMany(u => u.Adress.City == city).ToList();
        //}

        public List<MedicalRecord> GetMedicalRecordsBySpecialityId(int id)
        {
            return uow.MedicalRecordRepository.GetMany(u => u.Speciality.Id == id).ToList();
        }

        public List<Infos> GetProvidersBySpecialityId(int id)
        {
            if (uow.SpecialityRepository.GetById(id).Infos.ToList() == null)
            { return null; }
            else { return uow.SpecialityRepository.GetById(id).Infos.ToList(); }
            
        }

        //    public List<ServiceProvider> GetProvidersBySpecialityId(Speciality speciality)
        //    {

        //        return uow.ServiceProviderRepository.GetMany(u => u.Specialities.Contains<Speciality>(speciality)).ToList();
        //    }

        public Speciality GetSpecialityById(int id)
        {
            return uow.SpecialityRepository.GetById(id);
        }

        public IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id)
        {
            var test = uow.InfosRepository.GetAllInfosBySpecialityId(id);
            test.Count();
            return test;

        }
    }

}
