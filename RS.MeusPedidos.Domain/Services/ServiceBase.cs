using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity>
        where TEntity : class
    {
        protected readonly IRepositoryBase<TEntity> Repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            Repository = repository;
        }

        public void Add(TEntity obj)
        {
            Repository.Add(obj);
        }

        public TEntity GetById(Guid id)
        {
            return Repository.GetById(id);
        }

        public IEnumerable<TEntity> All()
        {
            return Repository.All();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Find(predicate);
        }

        public void Update(TEntity obj)
        {
            Repository.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            Repository.Delete(obj);
        }

        public void Dispose()
        {
            Repository.Dispose();
        }
    }
}
