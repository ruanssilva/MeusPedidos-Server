using Ninject.Modules;
using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain.Interfaces.Services;
using RS.MeusPedidos.Domain.Services;
using RS.MeusPedidos.Infrastructure.Data.Repository.EF;

namespace RS.MeusPedidos.Infrastructure.CrossCutting.IoC.Domain
{
    public class Modules : NinjectModule
    {
        public override void Load()
        {
            Bind<IAvaliacaoRepository>().To<AvaliacaoRepository>();
            Bind<IAvaliacaoService>().To<AvaliacaoService>();

            Bind<ICandidatoRepository>().To<CandidatoRepository>();
            Bind<ICandidatoService>().To<CandidatoService>();

            Bind<ICondicaoRepository>().To<CondicaoRepository>();
            Bind<ICondicaoService>().To<CondicaoService>();

            Bind<IConhecimentoRepository>().To<ConhecimentoRepository>();
            Bind<IConhecimentoService>().To<ConhecimentoService>();

            Bind<IPerfilRepository>().To<PerfilRepository>();
            Bind<IPerfilService>().To<PerfilService>();

            Bind<IRespostaRepository>().To<RespostaRepository>();
            Bind<IRespostaService>().To<RespostaService>();

            Bind<IEmailRepository>().To<EmailRepository>();
            Bind<IEmailService>().To<EmailService>();
        }
    }
}
