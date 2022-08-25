using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public class EfBaseRepository<T, ASContext> : IEfBaseRepository<T> where T : class where ASContext: DbContext
    {
        protected readonly ASContext Context;
        public EfBaseRepository(ASContext context)
        {
            Context = context;
        }
        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public T Get(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetByColor(Expression<Func<T, bool>> expression = null)
        {
            return Context.Set<T>().SingleOrDefault(expression);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public T TurnOnOff(T entity)
        {
            Context.Update(entity);
            return entity;
        }
    }
}
