using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain.Interfaces.Services;

namespace RS.MeusPedidos.Domain.Services
{
    public class AvaliacaoService : ServiceBase<Avaliacao>, IAvaliacaoService
    {
        public AvaliacaoService(IAvaliacaoRepository repository) :
            base(repository)
        {
        }
    }
}
