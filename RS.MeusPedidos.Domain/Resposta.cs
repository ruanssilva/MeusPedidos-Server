using System;
using System.Collections.Generic;
using System.Text;

namespace RS.MeusPedidos.Domain
{
    public class Resposta : Auditoria
    {
        public Guid AvaliacaoId { get; set; }
        public Guid ConhecimentoId { get; set; }
        public short Pontos { get; set; }

        public virtual Avaliacao Avaliacao { get; set; }
        public virtual Conhecimento Conhecimento { get; set; }
    }
}
