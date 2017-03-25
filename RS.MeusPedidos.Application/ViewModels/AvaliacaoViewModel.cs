using System;
using System.Collections.Generic;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class AvaliacaoViewModel
    {
        public Guid Id { get; set; }
        public Guid CandidatoId { get; set; }
        public IEnumerable<RespostaViewModel> RespostaSet { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}