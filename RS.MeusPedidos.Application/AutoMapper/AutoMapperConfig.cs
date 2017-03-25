using AutoMapper;
using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public override string ProfileName => "DomainToViewModelMappingProfile";

        public static void RegisterMappings()
        {
            Mapper.Initialize(i =>
            {
                i.CreateMap<Avaliacao, AvaliacaoViewModel>();
                i.CreateMap<Candidato, CandidatoViewModel>();
                i.CreateMap<Conhecimento, ConhecimentoViewModel>();
                i.CreateMap<Resposta, RespostaViewModel>()
                    .ForMember(fm => fm.Conhecimento, mo => mo.MapFrom(mp => mp != null ? mp.Conhecimento.Nome : string.Empty));
                i.CreateMap<Condicao, CondicaoViewModel>()
                    .ForMember(fm => fm.Conhecimento, mo => mo.MapFrom(mp => mp != null ? mp.Conhecimento.Nome : string.Empty));
                i.CreateMap<Perfil, PerfilViewModel>();
                i.CreateMap<Email, EmailViewModel>();


                i.CreateMap<AvaliacaoViewModel, Avaliacao>();
                i.CreateMap<CandidatoViewModel, Candidato>();
                i.CreateMap<ConhecimentoViewModel, Conhecimento>();
                i.CreateMap<RespostaViewModel, Resposta>()
                    .ForMember(fm => fm.Conhecimento, mo => mo.Ignore());
                i.CreateMap<CondicaoViewModel, Condicao>()
                    .ForMember(fm => fm.Conhecimento, mo => mo.Ignore());
                i.CreateMap<PerfilViewModel, Perfil>();
                i.CreateMap<EmailViewModel, Email>();
            });
        }
    }
}
