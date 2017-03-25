using System;
using System.Collections.Generic;

namespace RS.MeusPedidos.Domain
{
    public class Perfil : Auditoria
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? EmailId { get; set; }

        public virtual ICollection<Condicao> CondicaoSet { get; set; }
        public virtual Email Email { get; set; }
    }
}
