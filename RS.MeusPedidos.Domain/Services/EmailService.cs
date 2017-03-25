using RS.MeusPedidos.Domain.Interfaces.Repository;
using RS.MeusPedidos.Domain.Interfaces.Services;

namespace RS.MeusPedidos.Domain.Services
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        public EmailService(IEmailRepository repository)
            : base(repository)
        {
        }
    }
}
