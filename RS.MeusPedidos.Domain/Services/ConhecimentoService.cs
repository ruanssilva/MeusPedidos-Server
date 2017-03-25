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
    public class ConhecimentoService : ServiceBase<Conhecimento>, IConhecimentoService
    {
        public ConhecimentoService(IConhecimentoRepository repository)
            : base(repository)
        {
        }
    }
}
