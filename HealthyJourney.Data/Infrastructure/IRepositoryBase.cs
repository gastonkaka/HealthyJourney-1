using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Infrastructure
{
	public interface IRepository<T> where T : class //ellimine les structures, interface , enum, evenement
    {
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		void Delete(Expression<Func<T, bool>> where); // <Func<T, bool>> -->delegué sur le pointeur  //Expression -->lamda expression
        T GetById(long Id);
		T GetById(string Id);
		T Get(Expression<Func<T, bool>> where);  
		IEnumerable<T> GetAll();
		IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
	}

}
