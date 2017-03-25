using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class PerfilViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Perfil")]
        [MaxLength(65)]
        public string Nome { get; set; }
        [Display(Name = "Enviar o e-mail")]
        public Guid? EmailId { get; set; }
        [Display(Name = "Condições")]
        public IEnumerable<CondicaoViewModel> CondicaoSet { get; set; }
        public EmailViewModel Email { get; set; }
    }
}
