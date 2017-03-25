using System;
using System.Collections.Generic;
using System.Text;

namespace RS.MeusPedidos.Domain
{
    public class Auditoria
    {
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
