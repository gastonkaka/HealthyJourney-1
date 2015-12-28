using HealthyJourney.Domain.Entities;
using System.Collections.Generic;

namespace HealthyJourney.Service
{
    public interface ISpecialityServices
    {
      

        void AddSpeciality(Speciality spe);
        IEnumerable<Speciality> GetAllSpecialities();
        Speciality GetSpecialityById(int id);
        List<Infos> GetProvidersBySpecialityId(int id);
        List<MedicalRecord> GetMedicalRecordsBySpecialityId(int id);
        //List<User> GetUsersBySpecialityId(Speciality speciality);
        //List<User> GetByCity(string city);
        IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id);
       
    }
}
