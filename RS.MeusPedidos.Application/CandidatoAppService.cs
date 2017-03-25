using AutoMapper;
using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain.Interfaces.Services;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using RS.MeusPedidos.Infrastructure.CrossCutting.Utility;
using System.Threading;

namespace RS.MeusPedidos.Application
{
    public class CandidatoAppService : AppServiceBase<CandidatoViewModel, Candidato, ICandidatoService>, ICandidatoAppService
    {
        private readonly IAvaliacaoService _avaliacaoService;
        private readonly IPerfilAppService _perfilAppService;

        public CandidatoAppService(ICandidatoService service, IAvaliacaoService avaliacaoService, IPerfilAppService perfilAppService)
            : base(service)
        {
            _avaliacaoService = avaliacaoService;
            _perfilAppService = perfilAppService;
        }

        public CandidatoViewModel ObterPorId(Guid id)
        {
            var entity = Service.Find(f => f.Id == id).Single();

            var respostas = entity.AvaliacaoSet.Select(s => s).OrderByDescending(ob => ob.CreatedOn).Select(s => s.RespostaSet.Select(s1 => new RespostaViewModel
            {
                AvaliacaoId = s1.AvaliacaoId,
                Conhecimento = s1.Conhecimento?.Nome,
                ConhecimentoId = s1.ConhecimentoId,
                Pontos = s1.Pontos
            })).FirstOrDefault() ?? new List<RespostaViewModel>();

            var model = Mapper.Map<Candidato, CandidatoViewModel>(entity);
            model.RespostaSet = respostas;

            return model;
        }

        public CandidatoViewModel ObterPorEmail(string email, string nome)
        {
            var entity = Service.Find(f => f.Email == email && f.Nome == nome).FirstOrDefault();

            if (entity == null)
                return null;

            var respostas = entity.AvaliacaoSet.Select(s => s).OrderByDescending(ob => ob.CreatedOn).Select(s => s.RespostaSet.Select(s1 => new RespostaViewModel
            {
                AvaliacaoId = s1.AvaliacaoId,
                Conhecimento = s1.Conhecimento?.Nome,
                ConhecimentoId = s1.ConhecimentoId,
                Pontos = s1.Pontos
            })).FirstOrDefault() ?? new List<RespostaViewModel>();

            var model = Mapper.Map<Candidato, CandidatoViewModel>(entity);
            model.RespostaSet = respostas;

            return model;
        }

        public override CandidatoViewModel Incluir(CandidatoViewModel model)
        {
            Guid avaliacaoid = Guid.NewGuid();

            Candidato entity = Service.Find(f => f.Nome == model.Nome && f.Email == model.Email).SingleOrDefault();
            if (entity == null)
            {
                model.AvaliacaoSet = new List<AvaliacaoViewModel> {
                    new AvaliacaoViewModel {
                        CandidatoId = model.Id,
                        Id = avaliacaoid,
                        RespostaSet = model.RespostaSet.Select(s=> {
                            s.AvaliacaoId = avaliacaoid;
                            return s;
                        })
                    }
                };

                try
                {
                    SendMail(model);
                }
                finally
                {

                }

                return base.Incluir(model);
            }

            _avaliacaoService.Add(new Avaliacao
            {
                CandidatoId = entity.Id,
                Id = avaliacaoid,
                RespostaSet = model.RespostaSet.Select(s => new Resposta
                {
                    AvaliacaoId = avaliacaoid,
                    ConhecimentoId = s.ConhecimentoId,
                    Pontos = s.Pontos
                }).ToList()
            });

            entity.Perfil = SendMail(model);

            Service.Update(entity);

            return model;
        }

        public override CandidatoViewModel Atualizar(CandidatoViewModel model)
        {
            return Incluir(model);
        }

        private string SendMail(CandidatoViewModel model)
        {
            List<string> perfis = new List<string> { };
            foreach (var perfil in _perfilAppService.Todos())
            {
                bool atendeu = true;
                foreach (var condicao in perfil.CondicaoSet.Where(w => w.Pontos > 0))
                {
                    atendeu = model.RespostaSet.Where(w => w.ConhecimentoId == condicao.ConhecimentoId && w.Pontos >= condicao.Pontos).Count() == 1;
                    if (!atendeu)
                        break;
                }

                if (atendeu && !perfis.Contains(perfil.Email.Identificador))
                {
                    perfis.Add(perfil.Email.Identificador);

                    Mail.Send(perfil.Email.Assunto, perfil.Email.Conteudo, model.Email);
                }
            }

            if (perfis.Count() == 0)
            {
                Mail.Send(@"Obrigado por se candidatar", @"Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador entraremos em contato.", model.Email);
                return "Genérico";
            }

            return string.Join(" / ", perfis.OrderBy(d => d));
        }

        
    }
}
