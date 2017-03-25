using AutoMapper;
using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using RS.MeusPedidos.Domain;
using RS.MeusPedidos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application
{
    public class EmailAppService : AppServiceBase<EmailViewModel, Email, IEmailService>, IEmailAppService
    {
        public EmailAppService(IEmailService service)
            : base(service)
        {
        }

        public EmailViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Email, EmailViewModel>(Service.GetById(id));
        }

        public override EmailViewModel Atualizar(EmailViewModel model)
        {
            Email email = Service.GetById(model.Id);
            if (email == null)
                throw new KeyNotFoundException();

            email.Identificador = model.Identificador;
            email.Assunto = model.Assunto;
            email.Conteudo = model.Conteudo;

            Service.Update(email);

            return Mapper.Map<Email, EmailViewModel>(email);
        }
    }
}
