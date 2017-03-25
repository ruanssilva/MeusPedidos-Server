using AutoMapper;
using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain.Interfaces.Services;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application
{
    public class ConhecimentoAppService : AppServiceBase<ConhecimentoViewModel, Conhecimento, IConhecimentoService>, IConhecimentoAppService
    {
        public ConhecimentoAppService(IConhecimentoService service)
            : base(service)
        {
        }

        public ConhecimentoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Conhecimento, ConhecimentoViewModel>(Service.GetById(id));
        }

        public override ConhecimentoViewModel Atualizar(ConhecimentoViewModel model)
        {
            Conhecimento conhecimento = Service.GetById(model.Id);
            if (conhecimento == null)
                throw new KeyNotFoundException();

            conhecimento.Nome = model.Nome;

            Service.Update(conhecimento);

            return Mapper.Map<Conhecimento, ConhecimentoViewModel>(conhecimento);
        }
    }
}
