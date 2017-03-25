using RS.MeusPedidos.Domain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RS.MeusPedidos.Domain
{
    public class Avaliacao : Auditoria
    {
        public Guid Id { get; set; }
        public Guid CandidatoId { get; set; }

        public virtual ICollection<Resposta> RespostaSet { get; set; }
        public virtual Candidato Candidato { get; set; }
    }
}