using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.MeusPedidos.Infrastructure.Data.Interfaces.DbContexts;

namespace RS.MeusPedidos.Infrastructure.Data.Repository.EF
{
    public class AvaliacaoRepository : RepositoryBase<Avaliacao>, IAvaliacaoRepository
    {
        
    }
}
