using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Data.Infrastructure;

namespace HealthyJourney.Service
{
    class ServiceProviderServices : IServiceProviderServices
    {
        IUnitOfWork uow = null;
        public ServiceProviderServices()
        {
            uow = new UnitOfWork(new DatabaseFactory());
        }

        public void AddServiceProvider(ServiceProvider provider)
        {
            try
            {
                uow.ServiceProviderRepository.Add(provider);
                uow.Commit();

            }
            catch (Exception)
            {

                throw;
            }        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return uow.ServiceProviderRepository.GetAll().OfType<Doctor>().ToList();
        }

        public IEnumerable<Insurance> GetAllInsurances()
        {
            return uow.ServiceProviderRepository.GetAll().OfType<Insurance>().ToList();
        }

        public IEnumerable<MedicalCenter> GetAllMedicalCenters()
        {
            return uow.ServiceProviderRepository.GetAll().OfType<MedicalCenter>().ToList();
        }

        public IEnumerable<ServiceProvider> GetAllServiceProviders()
        {
            return uow.ServiceProviderRepository.GetAll().ToList();
        }
    }
}
