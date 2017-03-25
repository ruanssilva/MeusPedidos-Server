using RS.MeusPedidos.Infrastructure.Data.Interfaces.DbContexts;
using RS.MeusPedidos.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RS.MeusPedidos.Infrastructure.Data.DbContexts;

namespace RS.MeusPedidos.Infrastructure.Data.Repository.EF
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected static IDbContext Context;
        protected readonly IDbSet<TEntity> _dbset;
        protected readonly ObjectContext _objectcontext;
        protected readonly ObjectStateManager _objectstatemanager;
        protected readonly EntityContainer _entitycontainer;
        protected readonly EntitySetBase _entitysetbase;

        public RepositoryBase()
        {
            Context = Context ?? new MeusPedidosContext();
            _dbset = Context.Set<TEntity>();
            _objectcontext = ((IObjectContextAdapter)Context).ObjectContext;
            _objectstatemanager = _objectcontext.ObjectStateManager;
            _entitycontainer = _objectcontext.MetadataWorkspace.GetEntityContainer(_objectcontext.DefaultContainerName, DataSpace.CSpace);
            _entitysetbase = _entitycontainer.BaseEntitySets.Where(item => item.ElementType.Name.Equals(typeof(TEntity).Name)).FirstOrDefault();
        }

        public virtual void Add(TEntity entity)
        {
            _dbset.Add(entity);
            Context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            ObjectStateEntry state;

            bool attach = _objectstatemanager.TryGetObjectStateEntry(_objectcontext.CreateEntityKey(_entitysetbase.Name, entity), out state);
            if (!attach)
                Context.Entry(entity).State = EntityState.Modified;
            else
                state.SetModified();

            Context.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            ObjectStateEntry state;

            bool attach = _objectstatemanager.TryGetObjectStateEntry(_objectcontext.CreateEntityKey(_entitysetbase.Name, entity), out state);
            if (!attach)
                Context.Entry(entity).State = EntityState.Deleted;
            else
                state.Delete();

            Context.SaveChanges();
        }

        public virtual TEntity GetById(Guid Id)
        {
            return _dbset.Find(Id);
        }

        public virtual IEnumerable<TEntity> All()
        {
            return _dbset.AsNoTracking();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.AsNoTracking().Where(predicate);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (Context == null) return;
            Context.Dispose();
            Context = null;
        }
    }
}
