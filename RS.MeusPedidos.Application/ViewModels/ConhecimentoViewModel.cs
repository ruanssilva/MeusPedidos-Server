using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class ConhecimentoViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(65)]
        [Display(Name = "Conhecimento")]
        public string Nome { get; set; }
    }
}