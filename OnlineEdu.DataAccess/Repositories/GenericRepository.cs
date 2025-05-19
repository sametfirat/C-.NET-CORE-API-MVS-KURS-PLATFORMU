using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abctract;
using OnlineEdu.DataAccess.Context;

namespace OnlineEdu.DataAccess.Repositories
{
    public class GenericRepository<T>(OnlineEduContext context) : IRepository<T> where T : class
    {
        public DbSet<T> Table { get => context.Set<T>(); }

        public int Count()
        {
            return Table.Count();
        }

        public void create(T entity)
        {
            Table.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity);
            context.SaveChanges();
        }

        public int FilteredCount(Expression<Func<T, bool>> predicate)
        {
           return Table.Where(predicate).Count();
        }

        public T GetByFilter(Expression<Func<T, bool>> predicater)
        {
            return Table.Where(predicater).FirstOrDefault();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> Predicate)
        {
            return Table.Where(Predicate).ToList();
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            context.SaveChanges();
        }
    }
}
