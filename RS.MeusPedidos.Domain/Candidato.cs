using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;

namespace RS.MeusPedidos.Domain
{
    public class Candidato : Auditoria
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }

        public virtual ICollection<Avaliacao> AvaliacaoSet { get; set; }
    }
}
