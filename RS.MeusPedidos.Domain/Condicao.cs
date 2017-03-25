using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RS.MeusPedidos.Domain
{
    public class Condicao : Auditoria
    {
        public Guid ConhecimentoId { get; set; }
        public Guid PerfilId { get; set; }
        public short Pontos { get; set; }

        public virtual Conhecimento Conhecimento { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
