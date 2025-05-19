using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abctract
{
    public interface IRepository<T> where T : class
    {
     List<T> GetList();
        T GetById(int id);
        T GetByFilter (Expression<Func<T,bool>> predicater);
        void Update(T entity);
        void create(T entity);
        void Delete(int id);

        int Count();
        int FilteredCount(Expression<Func<T, bool>> Predicate);
        List<T> GetFilteredList(Expression<Func<T, bool>> Predicate);

    }
}
