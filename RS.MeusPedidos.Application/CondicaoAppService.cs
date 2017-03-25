using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain.Interfaces.Services;
using RS.MeusPedidos.Domain;

namespace RS.MeusPedidos.Application
{
    public class CondicaoAppService : AppServiceBase<CondicaoViewModel, Condicao, ICondicaoService>, ICondicaoAppService
    {
        public CondicaoAppService(ICondicaoService service)
            : base(service)
        {
        }
    }
}
