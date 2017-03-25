using System;
using System.ComponentModel.DataAnnotations;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class RespostaViewModel
    {
        public string Conhecimento { get; set; }
        public Guid AvaliacaoId { get; set; }
        [Required]
        [Display(Name = "Conhecimento")]
        public Guid ConhecimentoId { get; set; }
        [Required]
        public short Pontos { get; set; }
    }
}