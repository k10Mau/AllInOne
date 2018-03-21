using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MsTest.Demo.Contract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity FindByID(object id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
    }
}
