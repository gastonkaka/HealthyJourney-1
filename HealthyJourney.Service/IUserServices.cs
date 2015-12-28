using HealthyJourney.Domain.Entities;
using System.Collections.Generic;

namespace HealthyJourney.Service
{
    public interface IUserServices
    {

        void AddInfos(Infos infos);
        IEnumerable<User> GetAllUsers();
        IEnumerable<Infos> GetAllInfos();
        Infos GetById(string id);
        IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id);
        List<MedicalRecord> GetMedicalRecordsByUserId(int id);

    }
}
