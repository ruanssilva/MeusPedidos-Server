using RS.MeusPedidos.Domain;
using RS.MeusPedidos.Domain.Interfaces.Repository;

namespace RS.MeusPedidos.Infrastructure.Data.Repository.EF
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
    }
}
