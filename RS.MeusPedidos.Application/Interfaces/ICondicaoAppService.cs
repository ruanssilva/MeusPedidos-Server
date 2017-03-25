using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application.Interfaces
{
    public interface ICondicaoAppService : IAppServiceBase<CondicaoViewModel, Condicao>
    {
    }
}
