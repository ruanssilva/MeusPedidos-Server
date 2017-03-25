using Ninject.Modules;
using RS.MeusPedidos.Application;
using RS.MeusPedidos.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Infrastructure.CrossCutting.IoC.Application
{
    public class Modules : NinjectModule
    {
        public override void Load()
        {
            Bind<ICandidatoAppService>().To<CandidatoAppService>();
            Bind<IConhecimentoAppService>().To<ConhecimentoAppService>();
            Bind<IPerfilAppService>().To<PerfilAppService>();
            Bind<IEmailAppService>().To<EmailAppService>();
        }
    }
}
