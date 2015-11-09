using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Data.Infrastructure;

namespace HealthyJourney.Service
{
    class ClientServices : IClientServices
    {
        IUnitOfWork uow = null;
        public ClientServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

        public void AddClient(Client client)
        {
            try
            {
                uow.ClientRepository.Add(client);
                uow.Commit();

            }
            catch (Exception)
            {

                throw;
            }        }

        public IEnumerable<Client> GetAllClients()
        {
           return uow.ClientRepository.GetAll().ToList();
        }

        public List<MedicalRecord> GetMedicalRecordsByClientId(int id)
        {
           return uow.MedicalRecordRepository.GetMany(u => u.Client.Id == id).ToList();
        }
    }
}
