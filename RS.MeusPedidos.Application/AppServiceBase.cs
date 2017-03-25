using AutoMapper;
using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application
{
    public class AppServiceBase<TViewModel, TEntity, TIService> : IAppServiceBase<TViewModel, TEntity>
        where TViewModel : class
        where TEntity : class
        where TIService : IServiceBase<TEntity>
    {
        protected readonly TIService Service;

        public AppServiceBase(TIService service)
        {
            Service = service;
        }

        public virtual IEnumerable<TViewModel> Todos()
        {
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(Service.All().ToList());
        }

        public virtual IEnumerable<TViewModel> Filtrar(Expression<Func<TEntity, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> filter = predicate;

            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(Service.Find(predicate).ToList());
        }

        public virtual TViewModel Incluir(TViewModel model)
        {
            TEntity entity = Mapper.Map<TViewModel, TEntity>(model);

            Service.Add(entity);

            return Mapper.Map<TEntity, TViewModel>(entity);
        }

        public virtual TViewModel Atualizar(TViewModel model)
        {
            TEntity entity = Mapper.Map<TViewModel, TEntity>(model);

            Service.Update(entity);

            return Mapper.Map<TEntity, TViewModel>(entity);
        }

        public virtual void Remover(TViewModel model)
        {
            TEntity entity = Mapper.Map<TViewModel, TEntity>(model);

            Service.Delete(entity);
        }
    }
}
