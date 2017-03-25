using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RS.MeusPedidos.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
