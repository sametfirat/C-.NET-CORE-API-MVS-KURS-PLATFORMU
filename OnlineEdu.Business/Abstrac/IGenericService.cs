using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstrac
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetById(int id);
        T TGetByFilter(Expression<Func<T, bool>> predicater);
        void TUpdate(T entity);
        void Tcreate(T entity);
        void TDelete(int id);

        int TCount();
        int TFilteredCount(Expression<Func<T, bool>> Predicate);
        List<T> TGetFilteredList(Expression<Func<T, bool>> Predicate);
    }
}
