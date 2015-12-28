using HealthyJourney.Data.Infrastructure;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repositories
{
    public class InfosRepository : RepositoryBase<Infos>, IInfosRepository
    {

        IDatabaseFactory dbf = null;
        HealthyJourneyContext ctx;

        public InfosRepository(IDatabaseFactory dbf) : base(dbf)
        {
            this.dbf = dbf;
            ctx = dbf.DataContext;
        }

        public IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id)
        {
            return ctx.InfosSpecialities.Where(u => u.Speciality.Id == id).ToList();
        }
    }

    public interface IInfosRepository : IRepository<Infos>
    {
        IEnumerable<InfosSpeciality> GetAllInfosBySpecialityId(int id);


    }
}
