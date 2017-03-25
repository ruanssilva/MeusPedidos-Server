using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Domain
{
    public class Email : Auditoria
    {
        public Guid Id { get; set; }
        public string Identificador { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        

        public virtual ICollection<Perfil> PerfilSet { get; set; }
    }
}
