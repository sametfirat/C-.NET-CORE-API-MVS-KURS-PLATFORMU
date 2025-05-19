using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DataAccess.Abctract;

namespace OnlineEdu.Business.Concreat
{
    public class GenericManeger<T>(IRepository<T> repository) : IGenericService<T> where T : class
    {
        public void Tcreate(T entity)
        {
             repository.create(entity);
        }
        public void TDelete(int id)
        {
           repository.Delete(id);
        }
        public int TCount()
        {
           return  repository.Count();
        }
        public int TFilteredCount(System.Linq.Expressions.Expression<Func<T, bool>> Predicate)
        {
            return repository.FilteredCount(Predicate);
        }
        public List<T> TGetFilteredList(System.Linq.Expressions.Expression<Func<T, bool>> Predicate)
        {
            return repository.GetFilteredList(Predicate);
        }
        public T TGetByFilter(System.Linq.Expressions.Expression<Func<T, bool>> predicater)
        {
            return repository.GetByFilter(predicater);
        }
        public T TGetById(int id)
        {
            return repository.GetById(id);
        }
        public List<T> TGetList()
        {
           return repository.GetList();
        }
        public void TUpdate(T entity)
        {
           repository.Update(entity);
        }
    }
    
}
