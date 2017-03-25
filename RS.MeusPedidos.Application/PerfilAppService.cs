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
    public class PerfilAppService : AppServiceBase<PerfilViewModel, Perfil, IPerfilService>, IPerfilAppService
    {
        private readonly ICondicaoService _condicaoService;

        public PerfilAppService(IPerfilService service, ICondicaoService condicaoService)
            : base(service)
        {
            _condicaoService = condicaoService;
        }

        public PerfilViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Perfil, PerfilViewModel>(Service.GetById(id));
        }

        public override PerfilViewModel Atualizar(PerfilViewModel model)
        {
            Perfil perfil = Service.GetById(model.Id);
            if (perfil == null)
                throw new KeyNotFoundException();

            perfil.Nome = model.Nome;
            perfil.EmailId = model.EmailId;

            Condicao[] condicoes = perfil.CondicaoSet.ToArray();

            var modificados = model.CondicaoSet.Where(w => !condicoes.Select(s => s.ConhecimentoId).Contains(w.ConhecimentoId) ||
                                                           condicoes.Where(w2 => w2.ConhecimentoId == w.ConhecimentoId && w2.Pontos != w.Pontos).Count() == 1);

            foreach (var x in modificados)
            {
                if (condicoes.Where(w => w.ConhecimentoId == x.ConhecimentoId).Count() == 0)
                    perfil.CondicaoSet.Add(new Condicao
                    {
                        ConhecimentoId = x.ConhecimentoId,
                        PerfilId = perfil.Id,
                        Pontos = x.Pontos
                    });
                else
                    perfil.CondicaoSet.Where(w => w.ConhecimentoId == x.ConhecimentoId).Single().Pontos = x.Pontos;
            }

            Service.Update(perfil);

            return Mapper.Map<Perfil, PerfilViewModel>(perfil);
        }
    }
}
