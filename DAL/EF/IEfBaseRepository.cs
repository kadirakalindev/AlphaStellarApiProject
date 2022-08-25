using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public interface IEfBaseRepository <T> where T:class
    {
        T Get(T entity);
        T GetByColor(Expression<Func<T,bool>> expression = null);
        void Delete (T entity);
        T TurnOnOff (T entity);
        void SaveChanges();

    }
}
