using RS.MeusPedidos.Domain.Interfaces.Services;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.MeusPedidos.Domain.Interfaces.Repository;

namespace RS.MeusPedidos.Domain.Services
{
    public class CondicaoService : ServiceBase<Condicao>, ICondicaoService
    {
        public CondicaoService(ICondicaoRepository repository)
            : base(repository)
        {
        }
    }
}
