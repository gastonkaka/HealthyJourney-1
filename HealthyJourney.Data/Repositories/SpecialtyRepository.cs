using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repositories
{
    public class SpecialityRepository : RepositoryBase<Speciality>, ISpecialityRepository
    {
       
        

        public SpecialityRepository(IDatabaseFactory dbf) : base(dbf)
        {
         
        }

    }

    public interface ISpecialityRepository : IRepository<Speciality>
    {
       
      
    }
}
