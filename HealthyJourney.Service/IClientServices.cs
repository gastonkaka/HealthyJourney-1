using HealthyJourney.Domain.Entities;
using System.Collections.Generic;

namespace HealthyJourney.Service
{
    public interface IClientServices
    {
      

        void AddClient(Client client);
        IEnumerable<Client> GetAllClients();
        List<MedicalRecord> GetMedicalRecordsByClientId(int id);

    }
}
