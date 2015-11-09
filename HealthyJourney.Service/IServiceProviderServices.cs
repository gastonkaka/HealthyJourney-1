using HealthyJourney.Domain.Entities;
using System.Collections.Generic;

namespace HealthyJourney.Service
{
    public interface IServiceProviderServices
    {
       
        IEnumerable<ServiceProvider> GetAllServiceProviders();
        IEnumerable<Doctor> GetAllDoctors();
        IEnumerable<Insurance> GetAllInsurances();
        IEnumerable<MedicalCenter> GetAllMedicalCenters();

        void AddServiceProvider(ServiceProvider provider);


    }
}
