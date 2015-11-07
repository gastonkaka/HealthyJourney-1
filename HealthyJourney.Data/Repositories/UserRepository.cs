using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
       
        

        public UserRepository(IDatabaseFactory dbf) : base(dbf)
        {
         
        }

    }

    public interface IUserRepository : IRepository<User>
    {
       
      
    }
}
