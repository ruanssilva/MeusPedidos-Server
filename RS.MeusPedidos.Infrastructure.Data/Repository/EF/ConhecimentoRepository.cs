using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Infrastructure.Data.Repository.EF
{
    public class ConhecimentoRepository : RepositoryBase<Conhecimento>, IConhecimentoRepository
    {
    }
}
